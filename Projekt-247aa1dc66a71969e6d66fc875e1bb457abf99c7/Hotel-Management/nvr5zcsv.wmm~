using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblUsername.Text = Environment.UserName;
        }

        private void btnAllRooms_Click(object sender, EventArgs e)
        {
           
             frmAllRooms frmAllRooms_Vrb = new frmAllRooms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAllRooms_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(frmAllRooms_Vrb);
            frmAllRooms_Vrb.Show();
        }
    }
}
