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
    public partial class stuffsign : Form
    {
        DBAccess objdbaccess = new DBAccess();
        DataTable dtstuff = new DataTable();
        public stuffsign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo = new Form1();
            fo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string useremail = txtstuffsignemail.Text;
            string userpassword = txtstuffsignpassword.Text;
            if (useremail.Equals(""))
            {
                MessageBox.Show("enter email");
            }
            if (userpassword.Equals(""))
            {
                MessageBox.Show("enter password");
            }
            else
            {
                string query = "SELECt * from stuffs where stuffemail='" + useremail + "' AND stuffpassword='" + userpassword + "' ";
                objdbaccess.readDatathroughAdapter(query, dtstuff);
                if (dtstuff.Rows.Count == 1)
                {
                    MessageBox.Show("congratulations,you are loggin in successffully");
                    objdbaccess.closeConn();
                    this.Hide();
                    Staff s = new Staff();
                    s.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }
    }
}
