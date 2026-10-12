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
    public partial class register : Form
    {
        DBAccess objdBAccess = new DBAccess();

        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string phone = txtphone.Text;
            string address = txtaddress.Text;
            string age = txtage.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("please enter your name");
            }
            if (password.Equals(""))
            {
                MessageBox.Show("please enter your password");
            }
            if (phone.Equals(""))
            {
                MessageBox.Show("please enter your phone");
            }
            if (address.Equals(""))
            {
                MessageBox.Show("please enter your address");
            }
            if (age.Equals(""))
            {
                MessageBox.Show("please enter your age");
            }
            else
            {

                string constring = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
                SqlConnection condatabase = new SqlConnection(constring);
                
               
                
                    SqlCommand insertComand = new SqlCommand("insert into stuffs values('" + txtusername.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "','" + txtphone.Text + "','" + txtage.Text + "')", condatabase);
                    condatabase.Open();
                    insertComand.ExecuteNonQuery();
                    MessageBox.Show("Connection successfully");
                    condatabase.Close();
                /*

                else
                {

                    MessageBox.Show("error");
                }*/

            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
