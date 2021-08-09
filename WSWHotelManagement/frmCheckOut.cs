using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSWHotelManagement
{
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }
        funDB fn = new funDB();

        string query;

        private void tbRoomNumber_TextChanged(object sender, EventArgs e)
        {
            query = "select room from rooms where RoomNumber = '" + tbRoomNumber.Text + "' ";
            DataSet dataSet = fn.getData(query);
           tbName.Text = dataSet.Tables[0].Rows[0][0].ToString();
            roid = int.Parse(dataSet.Tables[0].Rows[0][1].ToString());
        }
    }
}
