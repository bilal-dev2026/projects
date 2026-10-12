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
    public partial class Main : Form
    {
        DBAccess objdBAccess = new DBAccess();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomlocation = txtroomlocationsearch.Text;
            string roomhead = txtroomheadsearch.Text;
            string roomchildren = txtchildrenroom.Text;
            if (roomlocation.Equals(""))
            {
                MessageBox.Show("write the location");
            }
            if (roomhead.Equals(""))
            {
                MessageBox.Show("write the room head");
            }
            if (roomchildren.Equals(""))
            {
                MessageBox.Show("write the Number Of Children");
            }
            else
            {
                string query = "UPDATE room SET roomlocation = '"+ txtroomlocationsearch.Text + "', roomhead='" + txtroomheadsearch.Text + "' WHERE roomid =" + int.Parse(txtroomsearch.Text) ;

                SqlCommand updatecommand = new SqlCommand(query);
                
                int row = objdBAccess.executeQuery(updatecommand);
                
                if(row == 1)
                {
                    MessageBox.Show("account created successfully");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtrooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string source = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            string selectquery = "SELECT * FROM room WHERE roomid ="+ int.Parse(txtroomsearch.Text) ;
            SqlCommand cmd = new SqlCommand(selectquery,con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtroomlocationsearch.Text = (dr["roomlocation"].ToString());
                txtroomheadsearch.Text = (dr["roomhead"].ToString());
                txtchildrenroom.Text = (dr["childnumber"].ToString());

            }
            else
            {
                txtroomlocationsearch.Text = "";
                txtroomheadsearch.Text = "";
                txtroomchildrensearch.Text = "";
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string roomlocation = txtroomlocationsearch.Text;
            string roomhead = txtroomheadsearch.Text;
            string roomchildren = txtchildrenroom.Text;
            if (roomlocation.Equals(""))
            {
                MessageBox.Show("write the location");
            }
            if (roomhead.Equals(""))
            {
                MessageBox.Show("write the room head");
            }
            if (roomchildren.Equals(""))
            {
                MessageBox.Show("write the Number Of Children");
            }
            else
            {
                string query = "DELETE FROM room WHERE roomid =" + int.Parse(txtroomsearch.Text);

                SqlCommand deletecommand = new SqlCommand(query);

                int row = objdBAccess.executeQuery(deletecommand);

                if (row == 1)
                {
                    MessageBox.Show("account deleted successfully");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            newroom nr = new newroom();
            nr.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sourcee = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection connn = new SqlConnection(sourcee);
            connn.Open();
            string selectquerry = "SELECT * FROM stuffs WHERE stuffid =" + int.Parse(txtstuffsearch.Text);
            SqlCommand cmdd = new SqlCommand(selectquerry, connn);
            SqlDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                txtstuffid.Text = (drr["stuffid"].ToString());
                txtstuffname.Text = (drr["stuffname"].ToString());
                txtstuffemail.Text = (drr["stuffemail"].ToString());
                txtstuffpassword.Text = (drr["stuffpassword"].ToString());
                txtstuffphone.Text = (drr["stuffphone"].ToString());
                txtstuffage.Text = (drr["stuffage"].ToString());
            }
            else
            {
                txtstuffid.Text = "";
                txtstuffname.Text = "";
                txtstuffemail.Text = "";
                txtstuffpassword.Text = "";
                txtstuffphone.Text = "";
                txtstuffage.Text = "";
            }
            connn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {


            string queery = "UPDATE stuffs SET stuffname = '" + txtstuffname.Text + "', stuffemail='" + txtstuffemail.Text + "',stuffpassword='" + txtstuffpassword.Text + "',stuffphone='" + txtstuffphone.Text + "',stuffage='" + txtstuffage.Text + "' WHERE stuffid =" + int.Parse(txtstuffsearch.Text);

            SqlCommand updatecommandd = new SqlCommand(queery);

            int row = objdBAccess.executeQuery(updatecommandd);

            if (row == 1)
            {
                MessageBox.Show("account Updated successfully");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sourcee = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection connn = new SqlConnection(sourcee);
            connn.Open();

            SqlCommand cmd = new SqlCommand("delete_staff", connn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", txtstuffsearch.Text));
            SqlDataReader readder = cmd.ExecuteReader();
            connn.Close();
           
                    MessageBox.Show("account deleted successfully");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            newstuff ns = new newstuff();
            ns.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string source = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection coon = new SqlConnection(source);
            coon.Open();
            string selecttquery = "SELECT * FROM child WHERE childid =" + int.Parse(txtchildsearch.Text);
            SqlCommand cmmd = new SqlCommand(selecttquery, coon);
            SqlDataReader dr = cmmd.ExecuteReader();
            if (dr.Read())
            {
                txtchildid.Text = (dr["childid"].ToString());
                txtchildname.Text = (dr["childname"].ToString());
                txtchildbirthday.Text = (dr["childage"].ToString());
                txtchildparent.Text = (dr["ch_parentid"].ToString());
                txtchildroom.Text = (dr["ch_roomid"].ToString());
            }
            else
            {
                txtchildid.Text = "";
                txtchildname.Text = "";
                txtchildbirthday.Text = "";
            }
            coon.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            newchild nc =new newchild();
            nc.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string coon = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            using (SqlConnection sqlconn = new SqlConnection(coon))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * from stuffs", sqlconn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                DGV1.DataSource = dtbl;
            }
        }

        private void DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string con = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                SqlDataAdapter sqld = new SqlDataAdapter("SELECT * from room", sqlcon);
                DataTable dtbl2 = new DataTable();
                sqld.Fill(dtbl2);
                DGV2.DataSource = dtbl2;
            }
        }

        private void txtroomlocationsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtchildrenroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

            string conn = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            using (SqlConnection sqlcoon = new SqlConnection(conn))
            {
                sqlcoon.Open();
                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT * from child", sqlcoon);
                DataTable dtbl3 = new DataTable();
                sqldata.Fill(dtbl3);
                DGV3.DataSource = dtbl3;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {


            string qquery = "UPDATE child SET childname = '" + txtchildname.Text + "', childage='" + txtchildbirthday.Text + "',ch_parentid='" + txtchildparent.Text + "',ch_roomid='" + txtchildroom.Text + "',nurserybus='" + txtbus.Text + "',paymentmethod='" + txtpaymethod.Text + "',paymentperiod='" + txtpayperiod.Text + "',addedExtratime='" + txtextratime.Text + "',parentfeedback='" + txtfeedback.Text + "' WHERE childid =" + int.Parse(txtchildsearch.Text);

            SqlCommand updatecommand = new SqlCommand(qquery);

            int row = objdBAccess.executeQuery(updatecommand);

            if (row == 1)
            {
                MessageBox.Show("account Updated successfully");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            string sourcee = "Data Source=AHMED;Initial Catalog=project;Integrated Security=True";
            SqlConnection connn = new SqlConnection(sourcee);
            connn.Open();

            SqlCommand cmd = new SqlCommand("delete_Childd", connn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", txtchildsearch.Text));
            SqlDataReader readder = cmd.ExecuteReader();
            connn.Close();



            connn.Open();

            SqlCommand cmmd = new SqlCommand("delete_Parent", connn);
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add(new SqlParameter("@id", txtchildsearch.Text));
            SqlDataReader reader = cmmd.ExecuteReader();
            connn.Close();

            MessageBox.Show("account deleted successfully");



            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
