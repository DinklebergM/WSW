using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace WSWHotelManagement
{
    public partial class frmRooms : Form
    {
        funDB fn = new funDB();
        
        string query;

        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet dataSet = fn.getData(query);
            DGVrooms.DataSource = dataSet.Tables[0];
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbDefaultPrice.Text != "" && tbRoomClass.Text != "" && tbRoomNumber.Text != "" && cbBed.Text != "" && cbExtraBed.Text != "")
            {
                string RoomNumber = tbRoomNumber.Text;               
                string RoomClass = tbRoomClass.Text;
                int Bed = int.Parse(cbBed.Text);
                int ExtraBed = int.Parse(cbExtraBed.Text);
                int Price = int.Parse(tbDefaultPrice.Text);

                query = "insert into rooms (RoomNumber,RoomClass,Bed,ExtraBeds,Price) values ('"+RoomNumber+"','"+RoomClass +"',"+Bed+","+ExtraBed+","+Price+")";
                fn.setData(query,"Room has been added");


                frmRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill Everything", "Warning");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbDefaultPrice.Text != "" && tbRoomClass.Text != "" && tbRoomNumber.Text != "" && cbBed.Text != "" && cbExtraBed.Text != "")
            {
                string RoomNumber = tbRoomNumber.Text;
                string RoomClass = tbRoomClass.Text;
                int Bed = int.Parse(cbBed.Text);
                int ExtraBed = int.Parse(cbExtraBed.Text);
                int Price = int.Parse(tbDefaultPrice.Text);

                query = "UPDATE rooms SET RoomClass='" + RoomClass + "', Bed=" + Bed + ", ExtraBeds= " + ExtraBed + ", Price=" + Price + " where RoomNumber = '" + RoomNumber + "'";
                fn.setData(query, "Room has been updatet");

                frmRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill Everything", "Warning");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse( Interaction.InputBox("Type room ID", "Delete Dialog"));

            var confirmResult = MessageBox.Show("Are you sure to delete this room??","Confirm Delete!!",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
               
                query = "DELETE from rooms where RoomNumber = " + id + "";
                fn.setData(query, "Room has been Deleted");
                frmRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("no");
                // If 'No', do something here.
            }
           }  
    }
}
