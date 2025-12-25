using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace asılProje
{
    public partial class Form1 : Form
    {
        public static int AktifKullaniciID = 0;

        VeriYoneticisi vy = new VeriYoneticisi();
        string hedefSayi = "";
        int haneSayisi = 3;
        int kalanHak = 10;
        int puan = 1000;
        int saniye = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (AktifKullaniciID == 0)                       //------------------------ GİRİŞ YAPILMAMIŞSA UYARI VER VE PROGRAMI KAPAT -----
            {
                MessageBox.Show("Lütfen önce giriş yapınız!");
                Application.Exit();
            }

            rb3Haneli.Checked = true;
            flowGecmis.FlowDirection = FlowDirection.TopDown; // Kutular alt alta dizilsin
            flowGecmis.AutoScroll = true; // Sığmazsa kaydırma çubuğu çıksın
            flowGecmis.WrapContents = false;

            YeniOyunBaslat();
            SkorlariListele();

        }

        // --- OYUNU BAŞLATMA VE SIFIRLAMA ---
        void YeniOyunBaslat()
        {
            // 1. Zorluk Seçimi (Soldaki kutucuklardan)
            if (rb3Haneli.Checked) haneSayisi = 3;
            else if (rb4Haneli.Checked) haneSayisi = 4;
            else if (rb5Haneli.Checked) haneSayisi = 5;

            // 2. Rastgele Benzersiz Sayı Üret
            Random rnd = new Random();
            hedefSayi = "";
            while (hedefSayi.Length < haneSayisi)
            {
                string rakam = rnd.Next(0, 10).ToString();
                if (!hedefSayi.Contains(rakam)) // Rakamları farklı olsun
                    hedefSayi += rakam;
            }

            // KOPYA (Test ederken formun tepesinde sayıyı gör, sonra bu satırı silersin)
            this.Text = "HEDEF SAYI: " + hedefSayi;

            // 3. Ekranı ve Puanları Sıfırla
            kalanHak = 10;
            puan = 1000 * haneSayisi;
            saniye = 0;

            lblKalanHak.Text = "KALAN HAK: " + kalanHak;
            lblAnlikPuan.Text = "PUAN: " + puan;
            lblSure.Text = "SÜRE: 0";

            txtTahminEkrani.Clear();
            flowGecmis.Controls.Clear(); // Geçmişi temizle

            timerOyunSuresi.Start();
        }


        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahminEkrani.Text;

            // Hata Kontrolü
            if (tahmin.Length != haneSayisi)
            {
                MessageBox.Show($"Lütfen {haneSayisi} haneli bir sayı girin!", "Eksik Tuşlama");
                return;
            }

            kalanHak--;
            lblKalanHak.Text = "KALAN HAK: " + kalanHak;

            // --- RENKLİ KUTULARI OLUŞTURMA ---
            Panel satir = new Panel(); // Her tahmin bir satır olacak
            satir.AutoSize = true;
            satir.Margin = new Padding(0, 0, 0, 10); // Satır arası boşluk

            int dogruYerde = 0;

            for (int i = 0; i < haneSayisi; i++)
            {
                Label kutu = new Label();
                kutu.Text = tahmin[i].ToString();
                kutu.Size = new Size(40, 40);
                kutu.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                kutu.ForeColor = Color.White;
                kutu.TextAlign = ContentAlignment.MiddleCenter;
                kutu.Location = new Point(i * 45, 0); // Yan yana diz

                // RENKLERİN AYARLANDIĞI YER
                if (tahmin[i] == hedefSayi[i])
                {
                    kutu.BackColor = Color.ForestGreen; // YEŞİL (Tam Doğru)
                    dogruYerde++;
                }
                else if (hedefSayi.Contains(tahmin[i].ToString()))
                {
                    kutu.BackColor = Color.DodgerBlue; // MAVİ (Var ama yeri yanlış)
                }
                else
                {
                    kutu.BackColor = Color.Crimson; // KIRMIZI (Yok)
                }

                satir.Controls.Add(kutu);
            }


            // Satırı geçmişe ekle (En üste gelmesi için 0. index)
            flowGecmis.Controls.Add(satir);
            flowGecmis.Controls.SetChildIndex(satir, 0);

            txtTahminEkrani.Clear(); // Yazı kutusunu temizle

            // KAZANMA / KAYBETME KONTROLÜ
            if (dogruYerde == haneSayisi)
            {
                timerOyunSuresi.Stop();
                SkorKaydet();
                SkorlariListele();
                MessageBox.Show($"TEBRİKLER! KAZANDINIZ.\nPuanınız: {puan}\nSüreniz: {saniye} sn");
                YeniOyunBaslat();
            }
            else if (kalanHak <= 0)
            {
                timerOyunSuresi.Stop();
                MessageBox.Show($"OYUN BİTTİ! Kaybettiniz.\nHedef Sayı: {hedefSayi}");
                YeniOyunBaslat();
            }
        }


        private void RakamBasildi(string rakam)
        {
            if (txtTahminEkrani.Text.Length < haneSayisi)
            {
                txtTahminEkrani.Text += rakam;
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTahminEkrani.Text.Length > 0)
            {
                txtTahminEkrani.Text = txtTahminEkrani.Text.Substring(0, txtTahminEkrani.Text.Length - 1);
            }
        }

        private void timerOyunSuresi_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSure.Text = "SÜRE: " + saniye;
            if (puan > 0) puan--;
            lblAnlikPuan.Text = "PUAN: " + puan;
        }
        private void rb3_CheckedChanged(object sender, EventArgs e) { if (rb3Haneli.Checked) YeniOyunBaslat(); }
        private void rb4_CheckedChanged(object sender, EventArgs e) { if (rb4Haneli.Checked) YeniOyunBaslat(); }
        private void rb5_CheckedChanged(object sender, EventArgs e) { if (rb5Haneli.Checked) YeniOyunBaslat(); }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RakamBasildi("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RakamBasildi("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RakamBasildi("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RakamBasildi("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RakamBasildi("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RakamBasildi("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RakamBasildi("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RakamBasildi("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RakamBasildi("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            RakamBasildi("0");
        }

        private void rb3Haneli_CheckedChanged(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void rb4Haneli_CheckedChanged(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void rb5Haneli_CheckedChanged(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTahminEkrani.Text.Length > 0)
            {
                txtTahminEkrani.Text = txtTahminEkrani.Text.Substring(0, txtTahminEkrani.Text.Length - 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnTahminEt_Click(sender, e);
        }

        // --- BU KODLARI Form1.cs EN ALTINA (Parantez kapanmadan önce) YAPIŞTIR ---

        // 1. SKOR KAYDETME FONKSİYONU
        void SkorKaydet()
        {
            try
            {
                using (SqlConnection baglanti = vy.BaglantiGetir())
                {
                    baglanti.Open();
                    // Skorlar tablosuna ekleme yapıyoruz
                    string sql = "INSERT INTO Skorlar (KullaniciID, Puan, SureSaniye, ZorlukSeviyesi) VALUES (@uid, @puan, @sure, @zorluk)";
                    SqlCommand komut = new SqlCommand(sql, baglanti);

                    komut.Parameters.AddWithValue("@uid", AktifKullaniciID);
                    komut.Parameters.AddWithValue("@puan", puan);
                    komut.Parameters.AddWithValue("@sure", saniye);
                    komut.Parameters.AddWithValue("@zorluk", haneSayisi + " Haneli");

                    komut.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Skor kaydedilirken hata oluştu: " + ex.Message);
            }
        }

        // 2. SKOR LİSTELEME FONKSİYONU (Sağdaki liste için)
        void SkorlariListele()
        {
            try
            {
                lstSkorlar.Items.Clear(); // Listeyi temizle

                using (SqlConnection baglanti = vy.BaglantiGetir())
                {
                    baglanti.Open();

                    // En yüksek 5 skoru getir
                    string sql = @"SELECT TOP 5 
                            k.KullaniciAdi, 
                            s.Puan, 
                            s.ZorlukSeviyesi
                           FROM Skorlar s
                           JOIN Kullanicilar k ON s.KullaniciID = k.KullaniciID
                           ORDER BY s.Puan DESC";

                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    int sira = 1; // SAYACI BAŞLAT

                    while (oku.Read())
                    {
                        // ÖRNEK ÇIKTI: "1. Ali - 500 Puan (3 Haneli)"
                        string satir = sira + ". " + oku["KullaniciAdi"].ToString() + " - " + oku["Puan"].ToString() + " Puan (" + oku["ZorlukSeviyesi"].ToString() + ")";

                        lstSkorlar.Items.Add(satir);

                        sira++; // SAYACI ARTTIR
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste hatası: " + ex.Message);
            }
        }

        private void bTN_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtTahminEkrani_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtTahminEkrani.Text.Length >= haneSayisi)
            {
                if (txtTahminEkrani.SelectionLength == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void lstSkorlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
