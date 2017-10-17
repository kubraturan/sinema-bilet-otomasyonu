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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source = DELL; Initial Catalog = sinemabiletotomasyonu; Integrated Security = True");
        private void tabPage4_Click(object sender, EventArgs e)
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string fkayit = "insert into film(filmId,filmAdi,sure,gosterimTarihi,ozet) values (@filmId,@filmAdi,@sure,@gosterimTarihi,@ozet)";

                SqlCommand komut = new SqlCommand(fkayit, con);

                komut.Parameters.AddWithValue("@filmId", textBox7.Text);
                komut.Parameters.AddWithValue("@filmAdi", textBox21.Text);
                komut.Parameters.AddWithValue("@sure", textBox12.Text);
                komut.Parameters.AddWithValue("@gosterimTarihi", textBox11.Text);
                komut.Parameters.AddWithValue("@ozet", textBox8.Text);
                komut.ExecuteNonQuery();


                con.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
            if (con.State == ConnectionState.Closed)
                con.Open();



            string tkayit = "insert into seans(seansId,seansSaati) values (@seansId,@seansSaati)";

            SqlCommand command = new SqlCommand(tkayit, con);

            command.Parameters.AddWithValue("@seansId", textBox10.Text);
            command.Parameters.AddWithValue("@seansSaati", textBox13.Text);
            command.ExecuteNonQuery();

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into filmSeans values('" + textBox7.Text + "','" + textBox10.Text + "')", con);
            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl4.SelectedIndex = 1;
            if (con.State == ConnectionState.Closed)
                con.Open();



            string tkayit = "insert into salon(salonId,salonHarfi) values (@salonId,@salonHarfi)";

            SqlCommand command = new SqlCommand(tkayit, con);

            command.Parameters.AddWithValue("@salonId", textBox20.Text);
            command.Parameters.AddWithValue("@salonHarfi", textBox22.Text);
            command.ExecuteNonQuery();

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into filmSalon values('" + textBox7.Text + "','" + textBox20.Text + "')", con);
            cmd1.ExecuteNonQuery();

            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedIndex = 1;
            if (con.State == ConnectionState.Closed)
                con.Open();



            string tkayit = "insert into tur(turId,turAdi) values (@turId,@turAdi)";

            SqlCommand command = new SqlCommand(tkayit, con);

            command.Parameters.AddWithValue("@turId", richTextBox1.Text);
            command.Parameters.AddWithValue("@turAdi", richTextBox2.Text);
            command.ExecuteNonQuery();

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into filmTürü values('" + textBox7.Text + "','" + richTextBox1.Text + "')", con);
            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedIndex = 2;
            if (con.State == ConnectionState.Closed)
                con.Open();


            string okayit = "insert into oyuncu(oyuncuId,oyuncuAdSoyad) values (@oyuncuId,@oyuncuAdSoyad)";

            SqlCommand komt = new SqlCommand(okayit, con);

            komt.Parameters.AddWithValue("@oyuncuId", richTextBox5.Text);
            komt.Parameters.AddWithValue("@oyuncuAdSoyad", richTextBox6.Text);
            komt.ExecuteNonQuery();
            con.Close();

            if (con.State == ConnectionState.Closed)
            {



                con.Open();


                SqlCommand cmd11 = new SqlCommand("Insert into filmOynar values('" + textBox7.Text + "','" + richTextBox5.Text + "')", con);
                cmd11.ExecuteNonQuery();


                con.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();




                string ykayit = "insert into yonetmen(yonetmenId,yonetmenAdSoyad) values (@yonetmenId,@yonetmenAdSoyad)";

                SqlCommand com = new SqlCommand(ykayit, con);

                com.Parameters.AddWithValue("@yonetmenId", richTextBox3.Text);
                com.Parameters.AddWithValue("@yonetmenAdSoyad", richTextBox4.Text);
                com.ExecuteNonQuery();

                SqlCommand cmd11 = new SqlCommand("Insert into filmYönetir values('" + textBox7.Text + "','" + richTextBox3.Text + "')", con);
                cmd11.ExecuteNonQuery();




                con.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();



            string tkayit = "update seans set(seansId,seansSaati) values (@seansId,@seansSaati)";

            SqlCommand command = new SqlCommand(tkayit, con);

            command.Parameters.AddWithValue("@seansId", textBox10.Text);
            command.Parameters.AddWithValue("@seansSaati", textBox13.Text);
            command.ExecuteNonQuery();

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("update filmSeans set  values('" + textBox7.Text + "','" + textBox10.Text + "')", con);
            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string fkayit = "update film set(filmId,filmAdi,sure,gosterimTarihi,ozet) values (@filmId,@filmAdi,@sure,@gosterimTarihi,@ozet)";

                SqlCommand komut = new SqlCommand(fkayit, con);

                komut.Parameters.AddWithValue("@filmId", textBox7.Text);
                komut.Parameters.AddWithValue("@filmAdi", textBox21.Text);
                komut.Parameters.AddWithValue("@sure", textBox12.Text);
                komut.Parameters.AddWithValue("@gosterimTarihi", textBox11.Text);
                komut.Parameters.AddWithValue("@ozet", textBox8.Text);
                komut.ExecuteNonQuery();


                con.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();



            string tkayit = "update tur set(turId,turAdi) values (@turId,@turAdi)";

            SqlCommand command = new SqlCommand(tkayit, con);

            command.Parameters.AddWithValue("@turId", richTextBox1.Text);
            command.Parameters.AddWithValue("@turAdi", richTextBox2.Text);
            command.ExecuteNonQuery();

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("update filmTürü set  values('" + textBox7.Text + "','" + richTextBox1.Text + "')", con);
            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();



            string tkayit = "update salon set(salonId,salonHarfi) values (@salonId,@salonHarfi)";

            SqlCommand command = new SqlCommand(tkayit, con);

            command.Parameters.AddWithValue("@salonId", textBox20.Text);
            command.Parameters.AddWithValue("@salonHarfi", textBox22.Text);
            command.ExecuteNonQuery();

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand cmd1 = new SqlCommand("update filmSalon set values('" + textBox7.Text + "','" + textBox20.Text + "')", con);
            cmd1.ExecuteNonQuery();

            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();


            string okayit = "update oyuncu set(oyuncuId,oyuncuAdSoyad) values (@oyuncuId,@oyuncuAdSoyad)";

            SqlCommand komt = new SqlCommand(okayit, con);

            komt.Parameters.AddWithValue("@oyuncuId", richTextBox5.Text);
            komt.Parameters.AddWithValue("@oyuncuAdSoyad", richTextBox6.Text);
            komt.ExecuteNonQuery();
            con.Close();

            if (con.State == ConnectionState.Closed)
            {



                con.Open();


                SqlCommand cmd11 = new SqlCommand("update filmOynar set  values('" + textBox7.Text + "','" + richTextBox5.Text + "')", con);
                cmd11.ExecuteNonQuery();


                con.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();




                string ykayit = "update yonetmen set (yonetmenId,yonetmenAdSoyad) values (@yonetmenId,@yonetmenAdSoyad)";

                SqlCommand com = new SqlCommand(ykayit, con);

                com.Parameters.AddWithValue("@yonetmenId", richTextBox3.Text);
                com.Parameters.AddWithValue("@yonetmenAdSoyad", richTextBox4.Text);
                com.ExecuteNonQuery();

                SqlCommand cmd11 = new SqlCommand("update filmYönetir set   values('" + textBox7.Text + "','" + richTextBox3.Text + "')", con);
                cmd11.ExecuteNonQuery();

                con.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string fkayit = "delete from film where filmId= 'textBox19.Text' ";

                SqlCommand komut = new SqlCommand(fkayit, con);

                komut.ExecuteNonQuery();


                con.Close();
            }
        }
    }
}
        
    



      

