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
namespace WindowsFormsApplication2
{
    public partial class Staff : Form
    {
        
       
        public Staff(stuffsign sta1)
        {
           
            InitializeComponent();


            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Nursery;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select Id,Location,Staff_Id from Room where Staff_Id= '"+sta1.textBox1.Text +"'", con);
            
            cmd.CommandType = CommandType.Text;
            
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl_room = new DataTable();
            tbl_room.Columns.Add("Id");
            tbl_room.Columns.Add("Location");
            tbl_room.Columns.Add("Staff_Id");

            DataRow row;
            while (reader.Read())
            {
                row = tbl_room.NewRow();
                row["Id"] = reader["Id"];
                row["Location"] = reader["Location"];
                row["Staff_Id"] = reader["Staff_Id"];
              
                tbl_room.Rows.Add(row);

            }


            reader.Close();
            con.Close();
            dgv_staff.DataSource = tbl_room;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Id, Name, Age,Staff_Id,Parent_Id,Room_Id, Features,Day_details  from Child where Staff_Id= '" + sta1.textBox1.Text + "'", con);
            cmd1.CommandType = CommandType.Text;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            DataTable tbl_child = new DataTable();
            tbl_child.Columns.Add("Id");
            tbl_child.Columns.Add("Name");
            tbl_child.Columns.Add("Age");
            tbl_child.Columns.Add("Staff_Id");
            tbl_child.Columns.Add("Parent_Id");
            tbl_child.Columns.Add("Room_Id");
            tbl_child.Columns.Add("Features");
            tbl_child.Columns.Add("Day_details");

            DataRow row1;
            while (reader1.Read())
            {
                row1= tbl_child.NewRow();
                row1["Id"] = reader1["Id"];
                row1["Name"] = reader1["Name"];
                row1["Age"] = reader1["Age"];
                row1["Staff_Id"] = reader1["Staff_Id"];
                row1["Parent_Id"] = reader1["Parent_Id"];
                row1["Room_Id"] = reader1["Room_Id"];
                row1["Features"] = reader1["Features"];
                row1["Day_details"] = reader1["Day_details"];
                tbl_child.Rows.Add(row1);

            }


            reader1.Close();
            con.Close();
            dgv_child.DataSource = tbl_child;
            


        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffLogin S = new StaffLogin();
            S.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
