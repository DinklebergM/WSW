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
using System.Configuration;

namespace Hotel_Management_
{
    public partial class frmAllRooms : Form
    {   
        SqlConnection sqlConnection ;

        public frmAllRooms()
        {
            
            string conStr = ConfigurationManager.ConnectionStrings["Hotel_Management_.Properties.Settings.HotelWSWConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(conStr);
            InitializeComponent();
           
        }
       
        private void ShowRooms()
        {

            string query = "select * from BigRoom";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader Reader = cmd.ExecuteReader();
            //  DataTable BigRoomTable = new DataTable();
            //sqlDataAdapter.Fill(BigRoomTable);

            listBR.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                listBR.Items.Add(lv);


            }

           
            Reader.Close();
            sqlConnection.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowRooms();
        }
    }
    }


 
