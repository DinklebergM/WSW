using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollection
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
            lblOWins.Text = "O Wins: " + owins.ToString();
            lblXWins.Text = "X Wins: " + xwins.ToString();
        }

        int xwins = 0;
        int owins = 0;

        Image X = Image.FromFile("x.jpg");
        Image O = Image.FromFile("o.jpg");

        int countdown = 10;

        bool last = false;

        private void pbA1_Click(object sender, EventArgs e)
        {
            pbA1.Image = whonow();
            whowon();
        }

        private void pbB1_Click(object sender, EventArgs e)
        {
            pbB1.Image = whonow();
            whowon();
        }

        private void pbC1_Click(object sender, EventArgs e)
        {
            pbC1.Image = whonow();
            whowon();
        }

        private void pbA2_Click(object sender, EventArgs e)
        {
            pbA2.Image = whonow();
            whowon();
        }

        private void pbB2_Click(object sender, EventArgs e)
        {
            pbB2.Image = whonow();
            whowon();
        }

        private void pbC2_Click(object sender, EventArgs e)
        {
            pbC2.Image = whonow();
            whowon();
        }

        private void pbA3_Click(object sender, EventArgs e)
        {
            pbA3.Image = whonow();
            whowon();
        }

        private void pbB3_Click(object sender, EventArgs e)
        {
            pbB3.Image = whonow();
            whowon();
        }

        private void pbC3_Click(object sender, EventArgs e)
        {
            pbC3.Image = whonow();
            whowon();
        }

        private bool wincheck()
        {

            if (pbA1.Image == pbA2.Image & pbA1.Image == pbA3.Image & pbA1.Image != null || pbB1.Image == pbB2.Image & pbB1.Image == pbB3.Image & pbB1.Image != null || pbC1.Image == pbC2.Image & pbC1.Image == pbC3.Image & pbC1.Image != null)
            {
                return true;
            }
            else if (pbA1.Image == pbB1.Image & pbA1.Image == pbC1.Image & pbA1.Image != null || pbA2.Image == pbB2.Image & pbA2.Image == pbC2.Image & pbA2.Image != null || pbA3.Image == pbB3.Image & pbA3.Image == pbC3.Image & pbA3.Image != null)
            {
                return true;
            }
            else if (pbA1.Image == pbB2.Image & pbA1.Image == pbC3.Image & pbA1.Image != null || pbC1.Image == pbB2.Image & pbC1.Image == pbA3.Image & pbC1.Image != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private Image whonow()
        {

            if (last)
            {
                last = false;
                return X;

            }
            else
            {
                last = true;
                return O;

            }
        }

        private void whowon()
        {

            if (wincheck())
            {
                if (last)
                {
                    MessageBox.Show("O HAT GEWONNEN!!!!");
                    owins++;
                    lblOWins.Text = "O Wins: " + owins.ToString();

                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("X HAT GEWONNEN!!!!");
                    xwins++;
                    lblXWins.Text = "X Wins: " + xwins.ToString();

                    timer1.Enabled = true;

                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblAutoRefresh.Text = "AutoRefresh: " + countdown.ToString();
            if (countdown == 0 )
            {
                if (pbA1.Image != null & pbB2.Image != null & pbC3.Image != null)
                {
                    btnRefresh_Click(sender, e);
                }
                
                timer1.Enabled = false;
                lblAutoRefresh.Text = "";
                countdown = 10;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pbA1.Image = null;
            pbA2.Image = null;
            pbA3.Image = null;

            pbB1.Image = null;
            pbB2.Image = null;
            pbB3.Image = null;

            pbC1.Image = null;
            pbC2.Image = null;
            pbC3.Image = null;
            
        }
    }
}
