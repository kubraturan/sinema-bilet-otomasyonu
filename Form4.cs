using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_bilet_otomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form6 filmislemleri = new Form6();
                filmislemleri.Show();
                this.Hide();

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 satsormislemleri = new Form7();
            satsormislemleri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 yoneticiekle = new Form8();
            yoneticiekle.Show();
            this.Hide();
        }
    }
}
