using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DestroyTheCubes;
using Microsoft.VisualBasic;

namespace GameCollection
{
    public partial class Form1 : Form
    {
        private object TicTacToe_Vrb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Image.FromFile("logo_large.png");
            lblName.Text = Environment.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDestroyTheCubes DestroyTheCubes_Vrb = new FormDestroyTheCubes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DestroyTheCubes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(DestroyTheCubes_Vrb);
            DestroyTheCubes_Vrb.Show();

        }

        private void btnTTT_Click(object sender, EventArgs e)
        {
            TicTacToe ticTacToe_Vrb = new TicTacToe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ticTacToe_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(ticTacToe_Vrb);
            ticTacToe_Vrb.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/proj");
        }

       
    }
}
