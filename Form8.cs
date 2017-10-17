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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = DELL; Initial Catalog = sinemabiletotomasyonu; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into yonetici(yonId,yonAdSoyad,sifre,adres,telefon) values (@yonId,@yonAdSoyad,@sifre,@adres,@telefon)";

                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@yonId", textBox8.Text);
                komut.Parameters.AddWithValue("@yonAdSoyad", textBox7.Text);
                komut.Parameters.AddWithValue("@sifre", textBox11.Text);
                komut.Parameters.AddWithValue("@adres", textBox12.Text);
                komut.Parameters.AddWithValue("@telefon", textBox1.Text);


                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yönetici Bilgileri Eklendi.");

            }
            catch (Exception hata1)
            {
                MessageBox.Show(hata1.Message);
            }

            textBox8.Clear();

            textBox7.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 geri = new Form4();
            geri.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string kayit = "update yonetici  set yonId=@yonId,yonAdSoyad=@yonAdSoyad,sifre=@sifre,adres=@adres,telefon=@telefon where yonId=@yonId";

                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@yonId", textBox9.Text);
                komut.Parameters.AddWithValue("@yonAdSoyad", textBox2.Text);
                komut.Parameters.AddWithValue("@sifre", textBox4.Text);
                komut.Parameters.AddWithValue("@adres", textBox5.Text);
                komut.Parameters.AddWithValue("@telefon", textBox3.Text);


                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yönetici Bilgileri Güncellendi.");

            }
            catch (Exception hata1)
            {
                MessageBox.Show(hata1.Message);
            }
            textBox9.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox3.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string kayit = "DELETE FROM yonetici WHERE yonId=@yonId";

                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@yonId", textBox10.Text);

                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Yönetici Bilgileri Silindi.");

            }
            catch (Exception hata1)
            {
                MessageBox.Show(hata1.Message);
            }

            textBox10.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 geri = new Form4();
            geri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 geri = new Form4();
            geri.Show();
            this.Hide();
        }
    }
}
  