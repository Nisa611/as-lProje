namespace asılProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnYeniOyun = new Button();
            label8 = new Label();
            rb5Haneli = new RadioButton();
            label6 = new Label();
            rb4Haneli = new RadioButton();
            label7 = new Label();
            rb3Haneli = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            bTN_cıkıs = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button6 = new Button();
            btn0 = new Button();
            btnSil = new Button();
            btn7 = new Button();
            button4 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            flowGecmis = new FlowLayoutPanel();
            label9 = new Label();
            btnTahminEt = new Button();
            txtTahminEkrani = new TextBox();
            lblKalanHak = new Label();
            lblSyı = new Label();
            panel5 = new Panel();
            lstSkorlar = new ListBox();
            lblSure = new Label();
            lblAnlikPuan = new Label();
            lblOyuncuAdi = new Label();
            label11 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            timerOyunSuresi = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowGecmis.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 10, 25);
            panel1.Controls.Add(btnYeniOyun);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(rb5Haneli);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(rb4Haneli);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(rb3Haneli);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Cyan;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 622);
            panel1.TabIndex = 0;
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.BackColor = Color.FromArgb(20, 20, 30);
            btnYeniOyun.Cursor = Cursors.Hand;
            btnYeniOyun.FlatAppearance.BorderColor = Color.Cyan;
            btnYeniOyun.FlatAppearance.BorderSize = 3;
            btnYeniOyun.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnYeniOyun.FlatStyle = FlatStyle.Flat;
            btnYeniOyun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYeniOyun.ForeColor = Color.Transparent;
            btnYeniOyun.Location = new Point(101, 521);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(145, 53);
            btnYeniOyun.TabIndex = 2;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = false;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Cyan;
            label8.Location = new Point(88, 274);
            label8.Name = "label8";
            label8.Size = new Size(194, 31);
            label8.TabIndex = 6;
            label8.Text = "OYUN AYARLARI";
            // 
            // rb5Haneli
            // 
            rb5Haneli.AutoSize = true;
            rb5Haneli.Checked = true;
            rb5Haneli.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            rb5Haneli.ForeColor = SystemColors.Control;
            rb5Haneli.Location = new Point(29, 445);
            rb5Haneli.Name = "rb5Haneli";
            rb5Haneli.Size = new Size(116, 34);
            rb5Haneli.TabIndex = 4;
            rb5Haneli.TabStop = true;
            rb5Haneli.Text = "5 Haneli";
            rb5Haneli.UseVisualStyleBackColor = true;
            rb5Haneli.CheckedChanged += rb5Haneli_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(136, 171);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 4;
            label6.Text = "Rakam Yok.";
            // 
            // rb4Haneli
            // 
            rb4Haneli.AutoSize = true;
            rb4Haneli.Checked = true;
            rb4Haneli.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            rb4Haneli.ForeColor = SystemColors.Control;
            rb4Haneli.Location = new Point(28, 394);
            rb4Haneli.Name = "rb4Haneli";
            rb4Haneli.Size = new Size(117, 34);
            rb4Haneli.TabIndex = 3;
            rb4Haneli.TabStop = true;
            rb4Haneli.Text = "4 Haneli";
            rb4Haneli.UseVisualStyleBackColor = true;
            rb4Haneli.CheckedChanged += rb4Haneli_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(52, 171);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 5;
            label7.Text = "KIRMIZI:";
            // 
            // rb3Haneli
            // 
            rb3Haneli.AutoSize = true;
            rb3Haneli.Checked = true;
            rb3Haneli.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            rb3Haneli.ForeColor = SystemColors.Control;
            rb3Haneli.Location = new Point(29, 342);
            rb3Haneli.Name = "rb3Haneli";
            rb3Haneli.Size = new Size(116, 34);
            rb3Haneli.TabIndex = 2;
            rb3Haneli.TabStop = true;
            rb3Haneli.Text = "3 Haneli";
            rb3Haneli.UseVisualStyleBackColor = true;
            rb3Haneli.CheckedChanged += rb3Haneli_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(52, 126);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 2;
            label4.Text = "MAVİ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(116, 126);
            label5.Name = "label5";
            label5.Size = new Size(179, 23);
            label5.TabIndex = 3;
            label5.Text = "Rakam Var, Yeri Yanlış.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(111, 81);
            label3.Name = "label3";
            label3.Size = new Size(175, 23);
            label3.TabIndex = 2;
            label3.Text = "Rakam ve Yeri Doğru.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(52, 81);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "YEŞİL: ";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 10, 25);
            button3.Enabled = false;
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(16, 119);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 10, 25);
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(16, 164);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 10, 25);
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(16, 74);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(201, 31);
            label1.TabIndex = 2;
            label1.Text = "NASIL OYNANIR?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(panel1);
            panel2.ImeMode = ImeMode.NoControl;
            panel2.Location = new Point(30, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 628);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(424, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 628);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(5, 10, 25);
            panel4.Controls.Add(bTN_cıkıs);
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(flowGecmis);
            panel4.Controls.Add(btnTahminEt);
            panel4.Controls.Add(txtTahminEkrani);
            panel4.Controls.Add(lblKalanHak);
            panel4.Controls.Add(lblSyı);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 622);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // bTN_cıkıs
            // 
            bTN_cıkıs.BackColor = Color.LightSteelBlue;
            bTN_cıkıs.Cursor = Cursors.Hand;
            bTN_cıkıs.FlatAppearance.BorderColor = Color.LightSteelBlue;
            bTN_cıkıs.FlatAppearance.BorderSize = 3;
            bTN_cıkıs.FlatAppearance.MouseOverBackColor = Color.Cyan;
            bTN_cıkıs.FlatStyle = FlatStyle.Flat;
            bTN_cıkıs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bTN_cıkıs.ForeColor = Color.FromArgb(20, 20, 30);
            bTN_cıkıs.Location = new Point(283, 198);
            bTN_cıkıs.Name = "bTN_cıkıs";
            bTN_cıkıs.Size = new Size(50, 45);
            bTN_cıkıs.TabIndex = 14;
            bTN_cıkıs.Text = "X";
            bTN_cıkıs.UseVisualStyleBackColor = false;
            bTN_cıkıs.Click += bTN_cıkıs_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(button6, 3, 2);
            tableLayoutPanel1.Controls.Add(btn0, 1, 3);
            tableLayoutPanel1.Controls.Add(btnSil, 3, 1);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Location = new Point(55, 425);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(320, 177);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.FlatAppearance.BorderColor = Color.RoyalBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(232, 91);
            button6.Name = "button6";
            tableLayoutPanel1.SetRowSpan(button6, 2);
            button6.Size = new Size(85, 83);
            button6.TabIndex = 7;
            button6.Text = "ONAYLA";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.MidnightBlue;
            btn0.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.ForeColor = Color.Transparent;
            btn0.Location = new Point(78, 138);
            btn0.Name = "btn0";
            btn0.Size = new Size(69, 36);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.MidnightBlue;
            btnSil.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.Transparent;
            btnSil.Location = new Point(232, 47);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(85, 38);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.MidnightBlue;
            btn7.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.ForeColor = Color.Transparent;
            btn7.Location = new Point(3, 91);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 38);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatAppearance.BorderColor = Color.RoyalBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(232, 3);
            button4.Name = "button4";
            button4.Size = new Size(85, 38);
            button4.TabIndex = 5;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.MidnightBlue;
            btn6.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.ForeColor = Color.Transparent;
            btn6.Location = new Point(153, 47);
            btn6.Name = "btn6";
            btn6.Size = new Size(73, 38);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.MidnightBlue;
            btn1.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = Color.Transparent;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 38);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            btn1.KeyPress += txtTahminEkrani_KeyPress;
            // 
            // btn2
            // 
            btn2.BackColor = Color.MidnightBlue;
            btn2.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.ForeColor = Color.Transparent;
            btn2.Location = new Point(78, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 38);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.MidnightBlue;
            btn3.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.ForeColor = Color.Transparent;
            btn3.Location = new Point(153, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(73, 38);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.MidnightBlue;
            btn8.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.ForeColor = Color.Transparent;
            btn8.Location = new Point(78, 91);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 38);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.MidnightBlue;
            btn5.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.ForeColor = Color.Transparent;
            btn5.Location = new Point(78, 47);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 38);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.MidnightBlue;
            btn9.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.ForeColor = Color.Transparent;
            btn9.Location = new Point(153, 91);
            btn9.Name = "btn9";
            btn9.Size = new Size(73, 38);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.MidnightBlue;
            btn4.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.ForeColor = Color.Transparent;
            btn4.Location = new Point(3, 47);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 38);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // flowGecmis
            // 
            flowGecmis.AutoScroll = true;
            flowGecmis.BackColor = Color.Transparent;
            flowGecmis.BorderStyle = BorderStyle.FixedSingle;
            flowGecmis.Controls.Add(label9);
            flowGecmis.FlowDirection = FlowDirection.TopDown;
            flowGecmis.Location = new Point(55, 259);
            flowGecmis.Name = "flowGecmis";
            flowGecmis.Size = new Size(320, 160);
            flowGecmis.TabIndex = 8;
            flowGecmis.WrapContents = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 0;
            label9.Text = "TAHMİN GEÇMİŞİ";
            // 
            // btnTahminEt
            // 
            btnTahminEt.BackColor = Color.Cyan;
            btnTahminEt.Cursor = Cursors.Hand;
            btnTahminEt.FlatAppearance.BorderColor = Color.Cyan;
            btnTahminEt.FlatAppearance.BorderSize = 3;
            btnTahminEt.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnTahminEt.FlatStyle = FlatStyle.Flat;
            btnTahminEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTahminEt.ForeColor = Color.FromArgb(20, 20, 30);
            btnTahminEt.Location = new Point(93, 198);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(184, 45);
            btnTahminEt.TabIndex = 7;
            btnTahminEt.Text = "TAHMİN ET";
            btnTahminEt.UseVisualStyleBackColor = false;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // txtTahminEkrani
            // 
            txtTahminEkrani.BackColor = Color.FromArgb(30, 30, 40);
            txtTahminEkrani.BorderStyle = BorderStyle.FixedSingle;
            txtTahminEkrani.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTahminEkrani.ForeColor = Color.White;
            txtTahminEkrani.Location = new Point(93, 119);
            txtTahminEkrani.Name = "txtTahminEkrani";
            txtTahminEkrani.ReadOnly = true;
            txtTahminEkrani.Size = new Size(240, 61);
            txtTahminEkrani.TabIndex = 2;
            txtTahminEkrani.TextAlign = HorizontalAlignment.Center;
            txtTahminEkrani.KeyPress += txtTahminEkrani_KeyPress;
            // 
            // lblKalanHak
            // 
            lblKalanHak.AutoSize = true;
            lblKalanHak.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKalanHak.ForeColor = Color.Transparent;
            lblKalanHak.Location = new Point(145, 72);
            lblKalanHak.Name = "lblKalanHak";
            lblKalanHak.Size = new Size(152, 28);
            lblKalanHak.TabIndex = 1;
            lblKalanHak.Text = "KALAN HAK: 10";
            // 
            // lblSyı
            // 
            lblSyı.AutoSize = true;
            lblSyı.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSyı.ForeColor = Color.Cyan;
            lblSyı.Location = new Point(126, 21);
            lblSyı.Name = "lblSyı";
            lblSyı.Size = new Size(207, 38);
            lblSyı.TabIndex = 0;
            lblSyı.Text = "SAYI TAHMİNİ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(5, 10, 25);
            panel5.Controls.Add(lstSkorlar);
            panel5.Controls.Add(lblSure);
            panel5.Controls.Add(lblAnlikPuan);
            panel5.Controls.Add(lblOyuncuAdi);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(414, 622);
            panel5.TabIndex = 3;
            // 
            // lstSkorlar
            // 
            lstSkorlar.BackColor = Color.FromArgb(5, 10, 25);
            lstSkorlar.BorderStyle = BorderStyle.None;
            lstSkorlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lstSkorlar.ForeColor = Color.White;
            lstSkorlar.FormattingEnabled = true;
            lstSkorlar.IntegralHeight = false;
            lstSkorlar.Location = new Point(40, 126);
            lstSkorlar.Name = "lstSkorlar";
            lstSkorlar.Size = new Size(314, 252);
            lstSkorlar.TabIndex = 12;
            lstSkorlar.SelectedIndexChanged += lstSkorlar_SelectedIndexChanged;
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSure.ForeColor = Color.Cyan;
            lblSure.Location = new Point(40, 507);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(77, 31);
            lblSure.TabIndex = 11;
            lblSure.Text = "SÜRE:";
            // 
            // lblAnlikPuan
            // 
            lblAnlikPuan.AutoSize = true;
            lblAnlikPuan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnlikPuan.ForeColor = Color.Cyan;
            lblAnlikPuan.Location = new Point(40, 448);
            lblAnlikPuan.Name = "lblAnlikPuan";
            lblAnlikPuan.Size = new Size(84, 31);
            lblAnlikPuan.TabIndex = 10;
            lblAnlikPuan.Text = "PUAN:";
            // 
            // lblOyuncuAdi
            // 
            lblOyuncuAdi.AutoSize = true;
            lblOyuncuAdi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOyuncuAdi.ForeColor = Color.Cyan;
            lblOyuncuAdi.Location = new Point(40, 388);
            lblOyuncuAdi.Name = "lblOyuncuAdi";
            lblOyuncuAdi.Size = new Size(123, 31);
            lblOyuncuAdi.TabIndex = 9;
            lblOyuncuAdi.Text = "OYUNCU: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(129, 72);
            label11.Name = "label11";
            label11.Size = new Size(174, 28);
            label11.TabIndex = 7;
            label11.Text = "En Yüksek Skorlar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Cyan;
            label10.Location = new Point(112, 21);
            label10.Name = "label10";
            label10.Size = new Size(219, 38);
            label10.TabIndex = 1;
            label10.Text = "SKOR TABLOSU";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cyan;
            panel6.Controls.Add(panel5);
            panel6.Location = new Point(912, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(422, 628);
            panel6.TabIndex = 0;
            // 
            // timerOyunSuresi
            // 
            timerOyunSuresi.Interval = 1000;
            timerOyunSuresi.Tick += timerOyunSuresi_Tick;
            // 
            // Form1
            // 
            AcceptButton = btnTahminEt;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 10, 25);
            ClientSize = new Size(1367, 682);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowGecmis.ResumeLayout(false);
            flowGecmis.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label5;
        private RadioButton rb3Haneli;
        private RadioButton rb4Haneli;
        private RadioButton rb5Haneli;
        private Button btnYeniOyun;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private Label lblKalanHak;
        private Label lblSyı;
        private TextBox txtTahminEkrani;
        private Button btnTahminEt;
        private FlowLayoutPanel flowGecmis;
        private Label label9;
        private Button btn1;
        private Button btn2;
        private Button btn8;
        private Button btn6;
        private Button btn3;
        private Button btn9;
        private Button btn7;
        private Button btn0;
        private Button btn5;
        private Button btn4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button btnSil;
        private Button button6;
        private Panel panel5;
        private Label label10;
        private Panel panel6;
        private Label label11;
        private Label lblSure;
        private Label lblAnlikPuan;
        private Label lblOyuncuAdi;
        private System.Windows.Forms.Timer timerOyunSuresi;
        private ListBox lstSkorlar;
        private Button bTN_cıkıs;
    }
}
