
namespace Kirtasiye_Otomasyon
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ana_gorsel = new System.Windows.Forms.PictureBox();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.checkBox_SifreyiGoster = new System.Windows.Forms.CheckBox();
            this.textBox_sifreGirisi = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciAdiGirisi = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ana_gorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // ana_gorsel
            // 
            this.ana_gorsel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ana_gorsel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ana_gorsel.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ana_gorsel.ErrorImage")));
            this.ana_gorsel.Image = ((System.Drawing.Image)(resources.GetObject("ana_gorsel.Image")));
            this.ana_gorsel.Location = new System.Drawing.Point(-2, 1);
            this.ana_gorsel.Name = "ana_gorsel";
            this.ana_gorsel.Size = new System.Drawing.Size(519, 488);
            this.ana_gorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ana_gorsel.TabIndex = 0;
            this.ana_gorsel.TabStop = false;
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonYeniKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonYeniKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYeniKayit.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.buttonYeniKayit.FlatAppearance.BorderSize = 5;
            this.buttonYeniKayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonYeniKayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonYeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYeniKayit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniKayit.Location = new System.Drawing.Point(150, 411);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(196, 48);
            this.buttonYeniKayit.TabIndex = 6;
            this.buttonYeniKayit.Text = "Yeni Kayıt Oluştur";
            this.buttonYeniKayit.UseVisualStyleBackColor = false;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            this.buttonYeniKayit.MouseLeave += new System.EventHandler(this.buttonYeniKayit_MouseLeave);
            this.buttonYeniKayit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonYeniKayit_MouseMove);
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGiris.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.buttonGiris.FlatAppearance.BorderSize = 5;
            this.buttonGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGiris.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(192, 350);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(117, 43);
            this.buttonGiris.TabIndex = 5;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseMnemonic = false;
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            this.buttonGiris.MouseLeave += new System.EventHandler(this.buttonGiris_MouseLeave);
            this.buttonGiris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonGiris_MouseMove);
            // 
            // checkBox_SifreyiGoster
            // 
            this.checkBox_SifreyiGoster.AutoSize = true;
            this.checkBox_SifreyiGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(180)))), ((int)(((byte)(152)))));
            this.checkBox_SifreyiGoster.Location = new System.Drawing.Point(340, 319);
            this.checkBox_SifreyiGoster.Name = "checkBox_SifreyiGoster";
            this.checkBox_SifreyiGoster.Size = new System.Drawing.Size(116, 21);
            this.checkBox_SifreyiGoster.TabIndex = 4;
            this.checkBox_SifreyiGoster.Text = "Şifreyi Göster";
            this.checkBox_SifreyiGoster.UseVisualStyleBackColor = false;
            this.checkBox_SifreyiGoster.CheckedChanged += new System.EventHandler(this.checkBox_SifreyiGoster_CheckedChanged);
            // 
            // textBox_sifreGirisi
            // 
            this.textBox_sifreGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(180)))), ((int)(((byte)(152)))));
            this.textBox_sifreGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifreGirisi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_sifreGirisi.Location = new System.Drawing.Point(143, 275);
            this.textBox_sifreGirisi.MaxLength = 8;
            this.textBox_sifreGirisi.Name = "textBox_sifreGirisi";
            this.textBox_sifreGirisi.PasswordChar = '*';
            this.textBox_sifreGirisi.Size = new System.Drawing.Size(227, 26);
            this.textBox_sifreGirisi.TabIndex = 3;
            // 
            // textBox_KullaniciAdiGirisi
            // 
            this.textBox_KullaniciAdiGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(180)))), ((int)(((byte)(152)))));
            this.textBox_KullaniciAdiGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KullaniciAdiGirisi.ForeColor = System.Drawing.Color.Black;
            this.textBox_KullaniciAdiGirisi.Location = new System.Drawing.Point(143, 218);
            this.textBox_KullaniciAdiGirisi.Name = "textBox_KullaniciAdiGirisi";
            this.textBox_KullaniciAdiGirisi.Size = new System.Drawing.Size(227, 26);
            this.textBox_KullaniciAdiGirisi.TabIndex = 2;
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(180)))), ((int)(((byte)(152)))));
            this.textBox_KullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_KullaniciAdi.Enabled = false;
            this.textBox_KullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.textBox_KullaniciAdi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(24, 223);
            this.textBox_KullaniciAdi.Multiline = true;
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.ReadOnly = true;
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(113, 28);
            this.textBox_KullaniciAdi.TabIndex = 7;
            this.textBox_KullaniciAdi.Text = "Kullanıcı Adı:";
            this.textBox_KullaniciAdi.WordWrap = false;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(180)))), ((int)(((byte)(152)))));
            this.textBoxSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSifre.Enabled = false;
            this.textBoxSifre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(83, 280);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(54, 21);
            this.textBoxSifre.TabIndex = 8;
            this.textBoxSifre.Text = "Şifre:";
            // 
            // AnaForm
            // 
            this.AcceptButton = this.buttonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 488);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Controls.Add(this.buttonYeniKayit);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBox_KullaniciAdiGirisi);
            this.Controls.Add(this.checkBox_SifreyiGoster);
            this.Controls.Add(this.textBox_sifreGirisi);
            this.Controls.Add(this.ana_gorsel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.ana_gorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ana_gorsel;
        private System.Windows.Forms.CheckBox checkBox_SifreyiGoster;
        private System.Windows.Forms.TextBox textBox_sifreGirisi;
        private System.Windows.Forms.TextBox textBox_KullaniciAdiGirisi;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Button buttonGiris;
    }
}

