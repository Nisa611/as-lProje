namespace asılProje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtKadi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtParola = new TextBox();
            btnGiris = new Button();
            btnKayit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKadi
            // 
            txtKadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKadi.Location = new Point(166, 121);
            txtKadi.Name = "txtKadi";
            txtKadi.Size = new Size(168, 34);
            txtKadi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 127);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 183);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "Parola :";
            // 
            // txtParola
            // 
            txtParola.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtParola.Location = new Point(166, 177);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(168, 34);
            txtParola.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Cyan;
            btnGiris.FlatAppearance.BorderColor = Color.Cyan;
            btnGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGiris.Location = new Point(197, 286);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(137, 43);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.Cyan;
            btnKayit.FlatAppearance.BorderColor = Color.Cyan;
            btnKayit.FlatAppearance.BorderSize = 0;
            btnKayit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnKayit.FlatStyle = FlatStyle.Flat;
            btnKayit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayit.Location = new Point(17, 286);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(137, 43);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "KAYIT OL";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(btnKayit);
            panel1.Controls.Add(txtKadi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtParola);
            panel1.Location = new Point(189, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 423);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Location = new Point(186, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 429);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.PowderBlue;
            label3.Location = new Point(17, 41);
            label3.Name = "label3";
            label3.Size = new Size(278, 37);
            label3.TabIndex = 6;
            label3.Text = "OYUNA KAYDOLUN :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 10, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtKadi;
        private Label label1;
        private Label label2;
        private TextBox txtParola;
        private Button btnGiris;
        private Button btnKayit;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
    }
}