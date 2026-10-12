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
namespace WindowsFormsApp2
{
    public partial class adminsign : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtadmin = new DataTable();
        public adminsign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string useremail = txtadminsignemail.Text;
            string userpassword = txtadminsignpassword.Text;
            if (useremail.Equals(""))
            {
                MessageBox.Show("enter email");
            }
            else if (userpassword.Equals(""))
            {
                MessageBox.Show("enter password");
            }
            else
            {
                string query = "SELECt * from stuffs where stuffemail='"+ useremail + "' AND stuffpassword='" + userpassword + "' AND stuffid=9 ";
                objDBAccess.readDatathroughAdapter(query, dtadmin);
                if (dtadmin.Rows.Count == 1)
                {
                    MessageBox.Show("congratulations,you are loggin in successffully");
                    objDBAccess.closeConn();
                    this.Hide();
                    Main adminview = new Main();
                    adminview.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void txtadminsignemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminsign_Load(object sender, EventArgs e)
        {

        }
    }
}
