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
    public partial class newstuff : Form
    {
        public newstuff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addname = txtnameadd.Text;
            string addemail = txtemailadd.Text;
            string addpassword = txtpasswordadd.Text;
            string addphone = txtphoneadd.Text;
            string addage = txtageadd.Text;
            if (addname.Equals(""))
            {
                MessageBox.Show("write name");
            }
            if (addemail.Equals(""))
            {
                MessageBox.Show("write email");
            }
            if (addpassword.Equals(""))
            {
                MessageBox.Show("write the password");
            }
            if (addphone.Equals(""))
            {
                MessageBox.Show("write phone");
            }
            if (addage.Equals(""))
            {
                MessageBox.Show("write age");
            }
            else
            {
                string constringg = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
                SqlConnection sqlconn = new SqlConnection(constringg);
                sqlconn.Open();


                SqlCommand addcommandd = new SqlCommand("insert_staffmember", sqlconn);
                addcommandd.CommandType = CommandType.StoredProcedure;
                addcommandd.Parameters.Add(new SqlParameter("@name", txtnameadd.Text));
                addcommandd.Parameters.Add(new SqlParameter("@email", txtemailadd.Text));
                addcommandd.Parameters.Add(new SqlParameter("@password", txtpasswordadd.Text));
                addcommandd.Parameters.Add(new SqlParameter("@phone", txtphoneadd.Text));
                addcommandd.Parameters.Add(new SqlParameter("@age", txtageadd.Text));

                SqlDataReader readerr = addcommandd.ExecuteReader();

                MessageBox.Show("Added successfully");
                sqlconn.Close();
                this.Hide();
                Main mn = new Main();
                mn.Show();
            }
        }
    }
}
