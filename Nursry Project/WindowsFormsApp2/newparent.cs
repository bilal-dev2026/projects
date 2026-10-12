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
using DatabaseProject;
namespace WindowsFormsApp2
{
    public partial class newparent : Form
    {
        public newparent()
        {
            InitializeComponent();
        }

        private void newparent_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cconstring = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection sqllcon = new SqlConnection(cconstring);
            string queery = "INSERT INTO parents values('" + txtparentname.Text + "','" + txtparentemail.Text + "','" + txtparentpassword.Text + "','" + parentphone.Text + "','" + parentage.Text + "') option(QUERYTRACEON 460)";
            SqlCommand addcommand = new SqlCommand(queery, sqllcon);
            sqllcon.Open();
            addcommand.ExecuteNonQuery();
            MessageBox.Show("Added successfully");
            sqllcon.Close();

            this.Hide();
            newchild ncc = new newchild();
            ncc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
