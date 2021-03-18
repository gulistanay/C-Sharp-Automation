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
    public partial class KullaniciKayitFormu : Form
    {
        SqlConnection baglanti;
        public KullaniciKayitFormu()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=LAPTOP-3QG4GP2V\\SQLEXPRESS;Initial Catalog=Kırtasiye_Otomasyon;Integrated Security=True"); 
        }

        private void buttonYeniKayit_Click(object sender, EventArgs e) // araştırıyorum bekle 
        {
            if (baglanti.State == ConnectionState.Closed)
            {

                baglanti.Open();
                //    SqlCommand komut = new SqlCommand("Insert into Kayit_tablosu (kullanici_adi, isim, soyisim, tckimlik, eposta, telefon, sifre, sifre_tekrar)values, ('" + textBox_kullaniciAdiKayit + "' , '" + textBox_isimKayit + "' , '" + textBox_soyisimKayit +
                //        "' , '" + textBox_tcKayit + "' , '" + textBox_epostaKayit + "' , '" + textBox_telefonKayit + "' , '" + textBox_sifreKayit + "' , '" + textBox_sifreTekrarKayit +)");

                if (textBox_kullaniciAdiKayit.Text == "" || textBox_sifreKayit.Text == "" || textBox_sifreTekrarKayit.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurun!");
                }
                else if ((textBox_telefonKayit.TextLength) > 10 || (textBox_telefonKayit.TextLength < 10))
                {
                    MessageBox.Show("Telefon numaranızı başında '0' olmadan ve 10 karakter olacak şekilde girmelisiniz! (ÖRNEK: 5304442211 )");
                }
                else if ((textBox_sifreKayit.TextLength > 8 && textBox_sifreTekrarKayit.TextLength > 8) || (textBox_sifreKayit.TextLength < 4 && textBox_sifreTekrarKayit.TextLength < 4))
                {
                    MessageBox.Show("Şifre en az 4 en fazla 8 karakter uzunluğunda olmalı!");
                }
                else if ((textBox_sifreKayit.Text) != (textBox_sifreTekrarKayit.Text))
                {
                    MessageBox.Show("Şifreler aynı değil! ");
                }
                else if ((textBox_tcKayit.TextLength) > 11 || (textBox_tcKayit.TextLength < 11) || (textBox_tcKayit.Text == ""))
                {
                    MessageBox.Show("TC kimlik numarası 11 rakamdan oluşmalı!");
                }

                else
                {
                    String query = "INSERT INTO dbo.Kayit_tablosu (kullanici_adi, isim, soyisim, tckimlik, eposta, telefon, sifre, sifre_tekrar) VALUES (@kullanici_adi, @isim, @soyisim, @tckimlik, @eposta, @telefon, @sifre, @sifre_tekrar)";

                    SqlCommand command = new SqlCommand(query, baglanti);
                    command.Parameters.AddWithValue("@kullanici_adi", textBox_kullaniciAdiKayit.Text);
                    command.Parameters.AddWithValue("@isim", textBox_isimKayit.Text);
                    command.Parameters.AddWithValue("@soyisim", textBox_soyisimKayit.Text);
                    command.Parameters.AddWithValue("@tckimlik", textBox_tcKayit.Text);
                    command.Parameters.AddWithValue("@eposta", textBox_epostaKayit.Text);
                    command.Parameters.AddWithValue("@telefon", textBox_telefonKayit.Text);
                    command.Parameters.AddWithValue("@sifre", textBox_sifreKayit.Text);
                    command.Parameters.AddWithValue("@sifre_tekrar", textBox_sifreTekrarKayit.Text);


                    command.ExecuteNonQuery();
                    //MessageBox.Show(test.ToString());
                    MessageBox.Show("Kayıt Başarılı");

                    textBox_kullaniciAdiKayit.Clear();
                    textBox_isimKayit.Clear();
                    textBox_soyisimKayit.Clear();
                    textBox_tcKayit.Clear();
                    textBox_epostaKayit.Clear();
                    textBox_telefonKayit.Clear();
                    textBox_sifreKayit.Clear();
                    textBox_sifreTekrarKayit.Clear();

                    this.Hide();
                    AnaForm form1 = new AnaForm(); //Giriş formuna yönlendirme
                    form1.Show();

                }
            }
            
            baglanti.Close();
       
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

        private void sadeceHarf(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void sadeceRakam(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_telefonKayit_Enter(object sender, EventArgs e)
        {
            if(textBox_telefonKayit.Text == "(5--)--------")
            {
                textBox_telefonKayit.Text = "";
                textBox_telefonKayit.ForeColor = Color.Black;
            }
        }

        private void textBox_telefonKayit_Leave(object sender, EventArgs e)
        {
            if (textBox_telefonKayit.Text == "")
            {
                textBox_telefonKayit.Text = "(5--)--------";
                textBox_telefonKayit.ForeColor = Color.Black;
            }
        }
    }
}
