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
    public partial class parent_view : Form
    {
        public parent_view()
        {
            InitializeComponent();
        }
        public parent_view(string parentemail)
        {
            InitializeComponent();
            label8.Text = parentemail;
               
               string constringg = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
               SqlConnection sqlconn = new SqlConnection(constringg);
               sqlconn.Open();
               string query = "SELECT * from parent where parentid =" + int.Parse(label8.Text);
               SqlCommand cmd = new SqlCommand(query, sqlconn);

               SqlDataReader drr = cmd.ExecuteReader();
               if (drr.Read())
               {
                   txtchildidd.Text = (drr["parentname"].ToString());

               }
               sqlconn.Close();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void parent_view_Load(object sender, EventArgs e)
        {
            string constringg = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(constringg);
            sqlconn.Open();
            string query = "SELECT childid from child where ch_parentid =" + int.Parse(label8.Text);
            SqlCommand cmd = new SqlCommand(query, sqlconn);

            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.Read())
            {
                txtchildidd.Text = (drr["childid"].ToString());
            }
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent_feedback pf = new parent_feedback();
            pf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string addday = txtday.Text;
            string addattendance = txtattendance.Text;
            string addoral = txtoral.Text;
            string addwriting = txtwriting.Text;
            string addbehavior = txtbehavior.Text;
            
            
                string constringg = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
                SqlConnection sqlconn = new SqlConnection(constringg);
                string queery = "INSERT INTO childprofile values('" + txtday.Text + "','" + txtattendance.Text + "','" + txtoral.Text + "','" + txtwriting.Text + "','" + txtbehavior.Text + "','')";
                SqlCommand addcommand = new SqlCommand(queery, sqlconn);
                sqlconn.Open();
                addcommand.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                sqlconn.Close();
                this.Hide();
                Main mn = new Main();
                mn.Show();
            }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourcee = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection connn = new SqlConnection(sourcee);
            connn.Open();
            string selectquerry = "SELECT * FROM childprofile WHERE child_idd ="+ int.Parse(txtchildidd.Text);
            SqlCommand cmdd = new SqlCommand(selectquerry, connn);
            SqlDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                txtday.Text = (drr["days"].ToString());
                txtattendance.Text = (drr["attendance"].ToString());
                txtoral.Text = (drr["oral"].ToString());
                txtwriting.Text = (drr["writinng"].ToString());
                txttasks.Text = (drr["tasks"].ToString());
                txtbehavior.Text = (drr["behavior"].ToString());
            }
            else
            {
                txtday.Text = "";
                txtattendance.Text = "";
                txtoral.Text = "";
                txtwriting.Text = "";
                txttasks.Text = "";
                txtbehavior.Text = "";
            }
            connn.Close();

        }
    }
    }

