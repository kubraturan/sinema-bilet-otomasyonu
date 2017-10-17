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

namespace sinema_bilet_otomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=sinemabiletotomasyonu;Integrated Security=True");
 
        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))

            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand com = new SqlCommand("SELECT *FROM satisSorumlusu WHERE satSormId=@satSormId AND sifre=@sifre", con);
                SqlParameter prms1 = new SqlParameter("@satSormId", textBox1.Text);
                SqlParameter prms2 = new SqlParameter("@sifre", textBox2.Text);

                com.Parameters.Add(prms1);
                com.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Satış Sorumlusu Giriş Paneline Hoşgeldiniz ", " Sayın  " + textBox1.Text);
                    this.Hide();
                    Form5 satis = new Form5();
                    satis.Show();

                }
                else
                {
                    MessageBox.Show("Veritabanında Böyle Bir Kullanıcı Bulunamadı..");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}