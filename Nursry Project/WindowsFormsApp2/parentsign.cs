using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    public partial class parentsign : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public parentsign()
        {
            InitializeComponent();
        }
        static string loggedinuser;

        private void button1_Click(object sender, EventArgs e)
        {

                string id = parentid.Text;
            
                string source = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
                SqlConnection coon = new SqlConnection(source);
                coon.Open();
                


                string querry = "SELECt * from parent where parentemail='" + parentemaill.Text + "' AND parentpassword='" + parentpasswordd.Text + "' AND parentid='" + parentid.Text + "' ";
                SqlCommand cmmd = new SqlCommand(querry, coon);
                SqlDataReader dr = cmmd.ExecuteReader();
                
                if (dr.Read())
                {
                    MessageBox.Show("congratulations,you are loggin in successffully");
                    loggedinuser = id;
                    this.Hide();
                    parent_view pvv = new parent_view(loggedinuser);
                    pvv.Show();
                    
                }
                else
                {
                    MessageBox.Show("error");
                }
                coon.Close();

            }

        private void parentsign_Load(object sender, EventArgs e)
        {

        }

        private void parentemaill_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

