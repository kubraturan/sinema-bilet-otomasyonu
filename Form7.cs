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
  
    
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = DELL; Initial Catalog = sinemabiletotomasyonu; Integrated Security = True");

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form4 geri = new Form4();
            geri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into satisSorumlusu(satSormId,satSormAdSoyad,Sifre,adres,telefon) values (@satSormId,@satSormAdSoyad,@Sifre,@adres,@telefon)";

                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@satSormId", textBox8.Text);
                komut.Parameters.AddWithValue("@satSormAdSoyad", textBox7.Text);
                komut.Parameters.AddWithValue("@Sifre", textBox11.Text);
                komut.Parameters.AddWithValue("@adres", textBox12.Text);
                komut.Parameters.AddWithValue("@telefon", textBox1.Text);


                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Satış Sorumlusu Bilgileri Eklendi. Hayırlı Olsun.");

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string kayit = "update satisSorumlusu  set satSormAdSoyad=@satSormAdSoyad,sifre=@sifre,adres=@adres,telefon=@telefon where satSormId=@satSormId";

                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@satSormId", textBox9.Text);
                komut.Parameters.AddWithValue("@satSormAdSoyad", textBox2.Text);
                komut.Parameters.AddWithValue("@sifre", textBox4.Text);
                komut.Parameters.AddWithValue("@adres", textBox5.Text);
                komut.Parameters.AddWithValue("@telefon", textBox3.Text);


                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Satış Sorumlusu Bilgileri Güncellendi.");

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

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 geri = new Form4();
            geri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string kayit = "DELETE FROM satisSorumlusu WHERE satSormId=@satSormId";

                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@satSormId", textBox6.Text);

                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Satış Sorumlusu Bilgileri Silindi.");

            }
            catch (Exception hata1)
            {
                MessageBox.Show(hata1.Message);
            }

            textBox6.Clear();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 geri = new Form4();
            geri.Show();
            this.Hide();
        }
    }
}
    
   
    

