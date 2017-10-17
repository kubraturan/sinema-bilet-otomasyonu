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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL;Initial Catalog=sinemabiletotomasyonu;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select *from film", con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["filmAdi"].ToString());

            }

        }
        SqlConnection bag = new SqlConnection(@"Data Source = DELL; Initial Catalog = sinemabiletotomasyonu; Integrated Security = True");
        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();


            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button2.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button2.Text;

        }
    

    private void button3_Click(object sender, EventArgs e)
    {
        bag.Open();



        SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button3.Text + " ')", bag);
        kmt.ExecuteNonQuery();
        bag.Close();

        textBox5.Text = textBox5.Text + "," + button3.Text;



    }







    private void button4_Click(object sender, EventArgs e)
{
    bag.Open();

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button4.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button4.Text;

        }


        private void button5_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button5.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button5.Text;

        

    }

private void button6_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button6.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button6.Text;


        }


        private void button7_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button7.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button7.Text;

        }



        private void button8_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button8.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button8.Text;

        }



        private void button9_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button9.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button9.Text;

        }



        private void button10_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button10.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button10.Text;

        }


        private void button11_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button11.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button11.Text;



        }

        private void button14_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button14.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button14.Text;

        }

        private void button15_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button15.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button15.Text;

        }

        private void button16_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button16.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button16.Text;

        }

        private void button17_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button17.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button17.Text;

        }

        private void button18_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button18.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button18.Text;

        }

        private void button19_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button19.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button19.Text;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button20.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button20.Text;
        }

private void button21_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button21.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button21.Text;

        }

private void button22_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button22.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button22.Text;
        }

private void button23_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button23.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button23.Text;
        }

private void button13_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button13.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button13.Text;
        }

private void button1_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button1.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button1.Text;
        }



private void button25_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button25.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button25.Text;

        }

private void button27_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button27.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button27.Text;
        }

private void button26_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button26.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button26.Text;
        }

private void button28_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button28.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button28.Text;

        }

private void button29_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button29.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button29.Text;

        }

private void button30_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button30.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button30.Text;
        }

private void button31_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button31.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button31.Text;
        }

private void button38_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button38.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button38.Text;
        }

//private void button31_Click(object sender, EventArgs e)
//{

//}

private void button32_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button32.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button32.Text;
        }

private void button33_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button33.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button33.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button34.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button34.Text;
        }
private void button45_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button45.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button45.Text;
        }

private void button35_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button35.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button35.Text;
        }

private void button36_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button36.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button36.Text;

        }

private void button37_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button37.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button37.Text;


        }

private void button39_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button39.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button39.Text;
        }

private void button40_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button40.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button40.Text;
        }

private void button41_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button41.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button41.Text;
        }

private void button42_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button42.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button42.Text;
        }

private void button43_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button43.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button43.Text;

        }

private void button44_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button44.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button44.Text;
        }

private void button79_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button79.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button79.Text;
        }

private void button78_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button78.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button78.Text;
        }

private void button55_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button55.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button55.Text;
        }

private void button54_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button54.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button54.Text;
        }

private void button53_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button53.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button53.Text;
        }

private void button52_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button52.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button52.Text;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button51.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button51.Text;
        }
private void button50_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button50.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button50.Text;
        }

private void button49_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button49.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button49.Text;

        }

private void button48_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button48.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button48.Text;
        }

private void button46_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button46.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button46.Text;
        }

private void button77_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button77.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button77.Text;

        }

private void button76_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button76.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button76.Text;

        }

private void button75_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button75.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button75.Text;

        }

private void button74_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button74.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button74.Text;
        }

private void button73_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button73.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button73.Text;

        }

private void button72_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button72.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button72.Text;

        }

private void button71_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button71.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button71.Text;
        }

private void button70_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button70.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button70.Text;
        }

private void button69_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button69.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button69.Text;
        }

private void button68_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button68.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button68.Text;
        }

private void button67_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button67.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button67.Text;

        }

private void button56_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button56.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button56.Text;
        }

private void button57_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button57.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button57.Text;
        }

private void button58_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button58.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button58.Text;
        }

private void button59_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button59.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button59.Text;
        }

private void button60_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button60.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button60.Text;
        }

        private void button61_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button61.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button61.Text;
        }

private void button62_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button62.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button62.Text;

        }

private void button63_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button63.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button63.Text;
        }

private void button64_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button64.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button64.Text;
        }

private void button65_Click(object sender, EventArgs e)
{

            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button65.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button65.Text;
        }

private void button66_Click(object sender, EventArgs e)
{
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button66.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button66.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand comut = new SqlCommand(" SELECT seansSaati from seans'", bag);
            SqlCommand komut = new SqlCommand(" SELECT salonHarfi from salon'", bag);

            comboBox1.Items.Add(comut);

            comboBox3.Items.Add(komut);
            textBox3.Text = comboBox1.SelectedItem.ToString();
            textBox1.Text = comboBox2.SelectedItem.ToString();
            textBox4.Text = comboBox3.SelectedItem.ToString();
            textBox6.Text= dateTimePicker1.Text;
            bag.Close();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            bag.Open();



            SqlCommand kmt = new SqlCommand("Insert Into dbo.koltuk(koltukid) values( '" + button12.Text + " ')", bag);
            kmt.ExecuteNonQuery();
            bag.Close();

            textBox5.Text = textBox5.Text + "," + button12.Text;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        //private void button65_Click_1(object sender, EventArgs e)
        //{

        //}
    }
        } 