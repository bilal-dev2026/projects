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
    public partial class newchild : Form
    {
        public newchild()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string addname = txtchildname.Text;
            string addbirthday = txtchildbirthday.Text;
            string addparent = txtchildparent.Text;
            string addroom = txtchildroom.Text;
            string addbus = txtbus.Text;
            string paymethod = txtpaymethod.Text;
            string payperiod = txtpayperiod.Text;
            string addextratime = txtextratime.Text;
            string feedback = txtfeedback.Text;
            if (addname.Equals(""))
            {
                MessageBox.Show("write name");
            }
            if (addbirthday.Equals(""))
            {
                MessageBox.Show("write the birthday");
            }
            if (addparent.Equals(""))
            {
                MessageBox.Show("write parent");
            }
            if (addroom.Equals(""))
            {
                MessageBox.Show("write room");
            }
            else
            {

                string cconstring = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(cconstring);

                sqlcon.Open();
                SqlCommand addcommand = new SqlCommand("insert_parentt", sqlcon);
                addcommand.CommandType = CommandType.StoredProcedure;
                addcommand.Parameters.Add(new SqlParameter("@name", txtparentname.Text));
                addcommand.Parameters.Add(new SqlParameter("@email", txtparentemail.Text));
                addcommand.Parameters.Add(new SqlParameter("@password", txtparentpassword.Text));
                addcommand.Parameters.Add(new SqlParameter("@phone", parentphone.Text));
                addcommand.Parameters.Add(new SqlParameter("@age", parentage.Text));
                SqlDataReader reader = addcommand.ExecuteReader();

                sqlcon.Close();

                sqlcon.Open();

                SqlCommand addcommandd = new SqlCommand("insert_child", sqlcon);
                addcommandd.CommandType = CommandType.StoredProcedure;
                addcommandd.Parameters.Add(new SqlParameter("@name", txtchildname.Text));
                addcommandd.Parameters.Add(new SqlParameter("@age", txtchildbirthday.Text));
                addcommandd.Parameters.Add(new SqlParameter("@ch_parentid", txtchildparent.Text));
                addcommandd.Parameters.Add(new SqlParameter("@ch_roomid", txtchildroom.Text));
                addcommandd.Parameters.Add(new SqlParameter("@nurserybus", txtbus.Text));
                addcommandd.Parameters.Add(new SqlParameter("@paymentmethod", txtpaymethod.Text));
                addcommandd.Parameters.Add(new SqlParameter("@paymentperiod", txtpayperiod.Text));
                addcommandd.Parameters.Add(new SqlParameter("@addedExtratime", txtextratime.Text));
                addcommandd.Parameters.Add(new SqlParameter("@parentfeedback", txtfeedback.Text));
                SqlDataReader readerr = addcommandd.ExecuteReader();
                MessageBox.Show("Added successfully");
                sqlcon.Close();
                this.Hide();
                Main mn = new Main();
                mn.Show();
            }
        }

        private void txtchildparent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
