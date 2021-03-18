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
    public partial class UrunlerFormu : Form
    {
        SqlConnection baglanti;
        public UrunlerFormu()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=LAPTOP-3QG4GP2V\\SQLEXPRESS;Initial Catalog=Kırtasiye_Otomasyon;Integrated Security=True");
        }

        private void UrunlerFormu_Load(object sender, EventArgs e)
        {
            comboBoxMarka.Items.Add("Faber Castell");  //Combobox a markaların eklenmesi işlemi

            comboBoxMarka.Items.Add("Gıpta");

            comboBoxMarka.Items.Add("DefTr");

            comboBoxMarka.Items.Add("Stabilo");

            comboBoxMarka.Items.Add("Mopak");

            comboBoxMarka.Items.Add("Uhu");

            comboBoxMarka.Items.Add("Diğer");
        }

        public void verileriGoster(string veriler)  //Sıkça kullanılacağı için verileri gösterme işlemi fonk olarak tanımlandı
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti); //Veritabanından verileri güncelleme sağlanacak
            DataSet ds = new DataSet(); //Yeni kaydı sql e ekler 
            da.Fill(ds); //verileri doldurma işlemi

            dataGridViewUrunler.DataSource = ds.Tables[0]; //0. hücreden itibaren tablodaki verileri çek
        }

        private void buttonGoruntule_Click(object sender, EventArgs e) //Üstte verileri gösterle ilgili tanımlamalar yapıldığı için tek satırla görüntüleme işlemi gerçekleştirildi
        {
            verileriGoster("Select * from  Urunler");
        }

        private void button_urunKaydet_Click(object sender, EventArgs e)  //Textboxlardan girilen ürünlerin kaydedilmesi işlemi
        {
            if (baglanti.State == ConnectionState.Closed) //Bağlantı hatasının önüne geçmek için bağlantı durumu kapalıysa açıp sonrasında işlemlere geçiş yapıldı
            {
                baglanti.Open();

                if (textBox_urunAdiKayit.Text == "" || textBox_FiyatKayit.Text == "" || textBox_BarkodKayit.Text == "" || textBox_StokAdetKayit.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurun!");  //Belirli alanların boş geçilmesi önlendi
                }
                else
                {
                    try //Hatayı yakalamak için gerekli kodlar try catch blogu içine yazıldı
                    {

                        SqlCommand komut = new SqlCommand("Insert into Urunler (urun_adi, Kategori, Marka, Fiyat, barkod_no, renk, Stok_Adedi) values (@1,@2,@3,@4,@5,@6,@7)", baglanti);

                        komut.Parameters.AddWithValue("@1", textBox_urunAdiKayit.Text);  //Veritabanıyla ilişkilendirmeler yapıldı
                        komut.Parameters.AddWithValue("@2", textBox_kategoriKayit.Text);
                        komut.Parameters.AddWithValue("@3", comboBoxMarka.Text);
                        komut.Parameters.AddWithValue("@4", textBox_FiyatKayit.Text);
                        komut.Parameters.AddWithValue("@5", textBox_BarkodKayit.Text);
                        komut.Parameters.AddWithValue("@6", textBox_RenkKayit.Text);
                        komut.Parameters.AddWithValue("@7", textBox_StokAdetKayit.Text);



                        komut.ExecuteNonQuery(); // Yukarıda parametreleri ile belirtilen SQL cümlesini veritabanına işler.
                        verileriGoster("Select * from Urunler");


                        textBox_urunAdiKayit.Clear();  //Kayıt yapıldıktan sonra textboxların içerikleri temizlendi
                        textBox_kategoriKayit.Clear();
                        textBox_FiyatKayit.Clear();
                        textBox_BarkodKayit.Clear();
                        textBox_StokAdetKayit.Clear();
                        textBox_RenkKayit.Clear();
                        textBox_urunAdiKayit.Focus();    //İlk textbox a konumlandırma işlemi

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata! " + ex.Message);
                    }
                }
            }
            baglanti.Close();

        }

        private void dataGridViewUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUrunler.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //Kolonları metin genişliğine göre otomatik ayarlar.
        }

        private void buttonKayitSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                try
                {
                    SqlCommand komut = new SqlCommand("Delete from Urunler where urun_adi =  @ad", baglanti);
                    komut.Parameters.AddWithValue("@ad", textBox_Ara.Text);
                    komut.ExecuteNonQuery();
              
                    MessageBox.Show("Kayıt Silindi");       //TextBox_Ara hem arama hem de kayıt silme işlemi için kullanıldı. ürün adı textBox_Ara ya girildikten sonra sil butonu ile silinmesi sağlandı

                    verileriGoster("Select * from Urunler");
                    textBox_Ara.Clear();  //TextBox içeriği temizlendi


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata! " + ex.Message); //Hata yakalandı
                }
                baglanti.Close();
            }
        }
        private void button_Ara_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();   
                try
                {                           //Arama işlemi için TextBox_Ara kullanıldı

                    SqlCommand komut = new SqlCommand("Select * from Urunler where urun_adi like '%" + textBox_Ara.Text + "%'", baglanti);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewUrunler.DataSource = ds.Tables[0];

                    textBox_Ara.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata! " + ex.Message);
                }
                baglanti.Close();
            }
        }

        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridViewUrunler.SelectedCells[0].RowIndex;     // DataGridView den seçilen alanın textboxlara geri yerleştirilmesi işlemi, Kayıt güncellemede kullanıldı
            string urun_ad = dataGridViewUrunler.Rows[seciliAlan].Cells[1].Value.ToString();
            string kategori = dataGridViewUrunler.Rows[seciliAlan].Cells[2].Value.ToString();
            string marka = dataGridViewUrunler.Rows[seciliAlan].Cells[3].Value.ToString();
            string fiyat = dataGridViewUrunler.Rows[seciliAlan].Cells[4].Value.ToString();
            string barkod_no = dataGridViewUrunler.Rows[seciliAlan].Cells[5].Value.ToString();
            string renk = dataGridViewUrunler.Rows[seciliAlan].Cells[6].Value.ToString();
            string stok_Adedi = dataGridViewUrunler.Rows[seciliAlan].Cells[7].Value.ToString();

            textBox_urunAdiKayit.Text = urun_ad;
            textBox_kategoriKayit.Text = kategori;
            comboBoxMarka.Text = marka;
            textBox_FiyatKayit.Text = fiyat;
            textBox_BarkodKayit.Text = barkod_no;
            textBox_RenkKayit.Text = renk;
            textBox_StokAdetKayit.Text = stok_Adedi;

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();        //ürün bilgisi üzerinde değişiklik yapmak istendiğinde, örneğin stok adetinin değiştirilmesi gibi, güncelle butonuyla verilerin güncellenmesi sağlandı

                    SqlCommand komut = new SqlCommand("UPDATE Urunler set Kategori = '" + textBox_kategoriKayit.Text + "', Marka = '" + comboBoxMarka.Text + "' , Fiyat = '" + textBox_FiyatKayit.Text + "' , barkod_no = '" + textBox_BarkodKayit.Text + "' , renk = '" + textBox_RenkKayit.Text + "' , Stok_Adedi= '" + textBox_StokAdetKayit.Text + "' where urun_adi = '" + textBox_urunAdiKayit.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    verileriGoster("Select * from Urunler");  //Fiyat textBoxında verinin temizlenerek yeni değerinin girilmesi gerekiyor. Aksi takdirde Sql ile bağlantıdan dolayı kaydı güncellerken sql deki virgül burada nokta olarak kullanıldığı için kayıt işleminde değerin yanına fazladan sıfır eklenme sorunu yaşanabiliyor

                    textBox_urunAdiKayit.Clear();  //Güncelleme yapıldıktan sonra textboxların içerikleri temizlendi
                    textBox_kategoriKayit.Clear();
                    textBox_FiyatKayit.Clear();
                    textBox_BarkodKayit.Clear();
                    textBox_StokAdetKayit.Clear();
                    textBox_RenkKayit.Clear();
                    textBox_urunAdiKayit.Focus();    //İlk textbox a konumlandırma işlemi


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncellemede Hata! " + ex.Message);
            }
            baglanti.Close();
        }

        private void buttonSepetGoruntule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSepet form4 = new FormSepet();
            form4.Show();
        }

        private void buttonSatislar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSiparisler form5 = new FormSiparisler();
            form5.Show();
        }

        private void buttonSepeteEkle_Click(object sender, EventArgs e)
        {
            //Sepete Ekleme işlemini yapamadım.
        }
    }
}
