using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            register rr = new register();
            rr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            stuffsign stuff = new stuffsign();
            stuff.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminsign adsign = new adminsign();
            adsign.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentsign parent = new parentsign();
            parent.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
