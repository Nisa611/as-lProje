
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;


namespace asılProje
{
    public partial class Form2 : Form
    {
        VeriYoneticisi vy = new VeriYoneticisi();

        public Form2()
        {
            InitializeComponent();
        }

        // --- GİRİŞ YAP BUTONU ---
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. Şifreyi şifrele (Veritabanındaki karmaşık haliyle karşılaştırmak için)
            string sifreliParola = vy.Sifrele(txtParola.Text);

            using (SqlConnection baglanti = vy.BaglantiGetir())
            {
                baglanti.Open();
                // 2. Kullanıcı adı ve şifresi uyan var mı bak
                string sql = "SELECT KullaniciID FROM Kullanicilar WHERE KullaniciAdi=@kadi AND ParolaHash=@pass";
                SqlCommand komut = new SqlCommand(sql, baglanti);

                komut.Parameters.AddWithValue("@kadi", txtKadi.Text);
                komut.Parameters.AddWithValue("@pass", sifreliParola);

                object sonuc = komut.ExecuteScalar(); // Tek bir değer (ID) döner

                if (sonuc != null)
                {
                    // GİRİŞ BAŞARILI
                    MessageBox.Show("Giriş Başarılı! Oyun Başlıyor...");

                    // En Önemli Kısım: Kimin girdiğini Form1'e haber veriyoruz
                    Form1.AktifKullaniciID = Convert.ToInt32(sonuc);

                    // Oyunu Aç
                    Form1 oyunEkrani = new Form1();
                    oyunEkrani.Show();

                    // Giriş ekranını gizle
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Parola!");
                }
            }
        }

        // --- KAYIT OL BUTONU ---
        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (txtKadi.Text == "" || txtParola.Text == "")
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve parola giriniz.");
                    return;
                }

                string sifreliParola = vy.Sifrele(txtParola.Text);

                using (SqlConnection baglanti = vy.BaglantiGetir())
                {
                    baglanti.Open();
                    // Yeni kullanıcı ekle
                    // (Ad, Soyad gibi bilgileri şimdilik otomatik doldurdum, istersen formuna ekleyip buraya yazabilirsin)
                    string sql = "INSERT INTO Kullanicilar (KullaniciAdi, ParolaHash, Ad, Soyad, Telefon, Eposta) VALUES (@kadi, @pass, 'Misafir', 'Oyuncu', '000', 'Yok')";

                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@kadi", txtKadi.Text);
                    komut.Parameters.AddWithValue("@pass", sifreliParola);

                    komut.ExecuteNonQuery(); // Kaydı yap

                    MessageBox.Show("Kayıt Başarılı! Şimdi 'Giriş Yap' butonuna basabilirsin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor olabilir.\nHata: " + ex.Message);
            }
        }





        private void Form2_Load(object sender, EventArgs e)
        {
            // Form açılınca çalışacak kodlar buraya gelecek
            try
            {
                using (SqlConnection baglanti = vy.BaglantiGetir())
                {
                    baglanti.Open();

                    // 1. Kullanıcılar Tablosu Yoksa Oluştur
                    string sqlKullanici = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Kullanicilar')
                BEGIN
                    CREATE TABLE Kullanicilar (
                        KullaniciID INT PRIMARY KEY IDENTITY(1,1),
                        KullaniciAdi NVARCHAR(50),
                        ParolaHash NVARCHAR(MAX),
                        Ad NVARCHAR(50),
                        Soyad NVARCHAR(50),
                        Telefon NVARCHAR(20),
                        Eposta NVARCHAR(100)
                    );
                    -- Hazır Admin Ekleyelim
                    INSERT INTO Kullanicilar (KullaniciAdi, ParolaHash, Ad, Soyad) 
                    VALUES ('admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Admin', 'User');
                END";

                    SqlCommand komut1 = new SqlCommand(sqlKullanici, baglanti);
                    komut1.ExecuteNonQuery();

                    // 2. Skorlar Tablosu Yoksa Oluştur
                    string sqlSkor = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Skorlar')
                BEGIN
                    CREATE TABLE Skorlar (
                        SkorID INT PRIMARY KEY IDENTITY(1,1),
                        KullaniciID INT,
                        Puan INT,
                        SureSaniye INT,
                        ZorlukSeviyesi NVARCHAR(50),
                        Tarih DATETIME DEFAULT GETDATE()
                    );
                END";

                    SqlCommand komut2 = new SqlCommand(sqlSkor, baglanti);
                    komut2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Eğer veritabanı bağlantısı hiç yoksa burası hata verir
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
