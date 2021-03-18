using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kirtasiye_Otomasyon
{
    public partial class AnaForm : Form
    {
        public static SqlConnection baglanti;

        public AnaForm()
        {
            InitializeComponent();
            // Sql bağlantı cümlemiz. Veritabanı adı: Kırtasiye_Otomasyon, Windows authentication ile girdiğimiz için Integrated Security'yi true yaptık.
            baglanti = new SqlConnection("Data Source=LAPTOP-3QG4GP2V\\SQLEXPRESS;Initial Catalog=Kırtasiye_Otomasyon;Integrated Security=True"); 
        }

        private void checkBox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox_SifreyiGoster.Checked)
            {
                //Karakterleri göster. (Başlangıç durumu için propertiesden passwordChar * olarak ayarlandı.)
                textBox_sifreGirisi.PasswordChar = '\0';
            }
            //Değilse karakterlerin yerine * koy.
            else
            {
                textBox_sifreGirisi.PasswordChar = '*';
            }
        }

        bool giris;
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string kullanici_adi = textBox_KullaniciAdiGirisi.Text;
            string sifre = textBox_sifreGirisi.Text;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("Select * From kayit_tablosu", baglanti);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Veritabanında isim ve şifre alanındaki boşluklardan kaynaklı hatayı önlemek amacıyla TrimEnd() komutu kullanıldı.
                    if (textBox_KullaniciAdiGirisi.Text == reader["kullanici_adi"].ToString().TrimEnd() && textBox_sifreGirisi.Text == reader["sifre"].ToString().TrimEnd())
                    {
                        giris = true;
                        break;
                    }
                    else
                    {
                        giris = false;
                        //break;
                    }
                }
            }
            baglanti.Close();
            if (giris == true && textBox_KullaniciAdiGirisi.Text != "" && textBox_sifreGirisi.Text != "")
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız!", "Sistem");
                textBox_KullaniciAdiGirisi.Clear();
                textBox_sifreGirisi.Clear();

                this.Hide();
                UrunlerFormu formUrunler = new UrunlerFormu();
                formUrunler.Show();

            }
            else
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi kontrol edin!", "Sistem");
            
        }

        private void buttonYeniKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciKayitFormu form2 = new KullaniciKayitFormu();
            form2.Show();
        }
           

        private void buttonGiris_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonGiris.BackColor = Color.Tomato;
            this.buttonGiris.ForeColor = Color.White;
        }

        private void buttonYeniKayit_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonYeniKayit.BackColor = Color.Tomato;
            this.buttonYeniKayit.ForeColor = Color.White;
        }

        private void buttonYeniKayit_MouseLeave(object sender, EventArgs e)
        {
            this.buttonYeniKayit.BackColor = Color.DarkSalmon;
            this.buttonYeniKayit.ForeColor = Color.Black;
        }

        private void buttonGiris_MouseLeave(object sender, EventArgs e)
        {
            this.buttonGiris.BackColor = Color.DarkSalmon;
            this.buttonGiris.ForeColor = Color.Black;
        }
    }
}
