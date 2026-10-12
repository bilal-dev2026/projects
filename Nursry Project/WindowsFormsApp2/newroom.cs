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
    public partial class newroom : Form
    {
        DBAccess dBAccess = new DBAccess();
        public newroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addlocation = txtlocationadd.Text;
            string addhead = txtheadadd.Text;
            string addchildren = txtchildrenadd.Text;
            if (addlocation.Equals(""))
            {
                MessageBox.Show("write location");
            }
            if (addhead.Equals(""))
            {
                MessageBox.Show("write the head");
            }
            if (addchildren.Equals(""))
            {
                MessageBox.Show("write the number of children");
            }
            else
            {
                string constring = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(constring);
                string query = "INSERT INTO room values('"+ txtlocationadd.Text +"','"+ txtheadadd.Text + "','" + txtchildrenadd.Text + "')";
                SqlCommand addcommand = new SqlCommand(query, sqlcon);
                sqlcon.Open();
                addcommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                sqlcon.Close();
                this.Hide();
                Main mn = new Main();
                mn.Show();
            }
        }
    }
}
