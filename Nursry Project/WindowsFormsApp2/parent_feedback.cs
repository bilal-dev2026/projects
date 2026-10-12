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

namespace WindowsFormsApp2
{
    public partial class parent_feedback : Form
    {
        public parent_feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cconstring = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(cconstring);
            string query = "UPDATE child SET parentfeedback = '" + txtfeedback.Text + "'  WHERE parentid = ch_parentid ";
            SqlCommand addfeedback = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            addfeedback.ExecuteNonQuery();
            MessageBox.Show("Added successfully");
            sqlcon.Close();
            this.Hide();
            parent_view pv = new parent_view();
            pv.Show();
        }
    }
}
