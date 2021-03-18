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
    public partial class FormSiparisler : Form
    {
        SqlConnection baglanti;
        public FormSiparisler()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=LAPTOP-3QG4GP2V\\SQLEXPRESS;Initial Catalog=Kırtasiye_Otomasyon;Integrated Security=True");
        }



        public void verileriGoster(string veriler)  //Sıkça kullanılacağı için verileri gösterme işlemi fonk olarak tanımlandı
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti); //Veritabanından verileri güncelleme sağlanacak
            DataSet ds = new DataSet();
            da.Fill(ds); 

            dataGridViewSiparisler.DataSource = ds.Tables[0]; //0. hücreden itibaren tablodaki verileri çek
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            verileriGoster("Select * from  Siparisler");
        }
    }
}
