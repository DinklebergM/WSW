using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DestroyTheCubes
{
    public partial class FormDestroyTheCubes : Form
    {
        public FormDestroyTheCubes()
        {
            InitializeComponent();
        }

        // FORM-LOAD
        private void FormDestroyTheCubes_Load(object sender, EventArgs e)
        {
            Player.BackColor = Color.DarkCyan;
            Player.ForeColor = Color.Red;
            PlayerLabel.ForeColor = Color.Red;
            PlayerLabel.Font = new Font("Arial", 15, FontStyle.Bold);
            CreateRandom();
            ButtonPause.Visible = false;
            MenuUI();
            DifficultyLabel.Visible = true;
            ButtonColorReroll.Visible = false;
            ButtonStop.Visible = false;
            LabelTimer.Top = 0;
            LabelTimer.Left = 435;
            LabelTimer.ForeColor = Color.Red;
            LabelTimer.Font = new Font("Arial", 28, FontStyle.Bold);
            Player.Left = 400;
            Player.Top = 400;
            PlayerLabel.Left = 425;
            PlayerLabel.Top = 450;
            GameTimer3.Enabled = false;

        }


        // GLOBALS, "globale" Variablen, wenn etwas passiert werden sie geändert, überall benutzt und gebraucht
        public static class Globals
        {
            public static int SpeedX1, SpeedY1, SpeedX2, SpeedY2, SpeedX3, SpeedY3, SpeedX4, SpeedY4, SpeedX5, SpeedY5, SpeedX6, SpeedY6, SpeedX7, SpeedY7, SpeedX8, SpeedY8;
            public static int E1Health, E2Health, E3Health, E4Health, E5Health, E6Health, E7Health, E8Health;
            public static int PlayerHealth = 100;
            public static double Difficulty = 2;
            public static int GameCooldown = 41;
            public static int PlayerSpeed = 3;
            public static bool moveLeft, moveRight, moveUp, moveDown, Boost;
            public static bool E1Alive = true;
            public static bool E2Alive = true;
            public static bool E3Alive = true;
            public static bool E4Alive = true;
            public static bool E5Alive = true;
            public static bool E6Alive = true;
            public static bool E7Alive = true;
            public static bool E8Alive = true;
            public static int IntersectionTimer1, IntersectionTimer2, IntersectionTimer3, IntersectionTimer4, IntersectionTimer5, IntersectionTimer6, IntersectionTimer7, IntersectionTimer8;
            public static Random rnd = new Random();
        }


        // RANDOM, erzeugt für die Globalen Variablen Randoms
        public void CreateRandom()
        {
            int[] SpeedValues = { -4, -3, -2, -1, 1, 2, 3, 4 };
            Globals.SpeedX1 = SpeedValues[CreateRandom2()];
            Globals.SpeedY1 = SpeedValues[CreateRandom2()];
            Globals.SpeedX2 = SpeedValues[CreateRandom2()];
            Globals.SpeedY2 = SpeedValues[CreateRandom2()];
            Globals.SpeedX3 = SpeedValues[CreateRandom2()];
            Globals.SpeedY3 = SpeedValues[CreateRandom2()];
            Globals.SpeedX4 = SpeedValues[CreateRandom2()];
            Globals.SpeedY4 = SpeedValues[CreateRandom2()];
            Globals.SpeedX5 = SpeedValues[CreateRandom2()];
            Globals.SpeedY5 = SpeedValues[CreateRandom2()];
            Globals.SpeedX6 = SpeedValues[CreateRandom2()];
            Globals.SpeedY6 = SpeedValues[CreateRandom2()];
            Globals.SpeedX7 = SpeedValues[CreateRandom2()];
            Globals.SpeedY7 = SpeedValues[CreateRandom2()];
            Globals.SpeedX8 = SpeedValues[CreateRandom2()];
            Globals.SpeedY8 = SpeedValues[CreateRandom2()];
            switch (Globals.Difficulty)
            {
                case 1:
                    Globals.E1Health = Globals.rnd.Next(150, 200);
                    Globals.E2Health = Globals.rnd.Next(150, 200);
                    Globals.E3Health = Globals.rnd.Next(150, 200);
                    E1.Size = new Size(130, 130);
                    E2.Size = new Size(130, 130);
                    E3.Size = new Size(130, 130);
                    Globals.PlayerSpeed = 2;
                    break;
                case 2:
                    Globals.E1Health = Globals.rnd.Next(200, 250);
                    Globals.E2Health = Globals.rnd.Next(200, 250);
                    Globals.E3Health = Globals.rnd.Next(200, 250);
                    Globals.E4Health = Globals.rnd.Next(200, 250);
                    Globals.E5Health = Globals.rnd.Next(200, 250);
                    E1.Size = new Size(100, 100);
                    E2.Size = new Size(100, 100);
                    E3.Size = new Size(100, 100);
                    E4.Size = new Size(100, 100);
                    E5.Size = new Size(100, 100);
                    Globals.PlayerSpeed = 3;
                    break;
                case 3:
                    Globals.E1Health = Globals.rnd.Next(250, 300);
                    Globals.E2Health = Globals.rnd.Next(250, 300);
                    Globals.E3Health = Globals.rnd.Next(250, 300);
                    Globals.E4Health = Globals.rnd.Next(250, 300);
                    Globals.E5Health = Globals.rnd.Next(250, 300);
                    Globals.E6Health = Globals.rnd.Next(250, 300);
                    Globals.E7Health = Globals.rnd.Next(250, 300);
                    Globals.E8Health = Globals.rnd.Next(250, 300);
                    E1.Size = new Size(70, 70);
                    E2.Size = new Size(70, 70);
                    E3.Size = new Size(70, 70);
                    E4.Size = new Size(70, 70);
                    E5.Size = new Size(70, 70);
                    E6.Size = new Size(70, 70);
                    E7.Size = new Size(70, 70);
                    E8.Size = new Size(70, 70);
                    Globals.PlayerSpeed = 4;
                    break;
            }

        }
        public int CreateRandom2()
        {
            return Globals.rnd.Next(1, 8);
        }


        //CREATECOLOR, Erstellt Random-Farben für Enemys
        public void CreateColors()
        {
            Random rnd = new Random();
            E1.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E2.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E3.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E4.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E5.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E6.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E7.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            E8.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }


        // TIMER-TICK, aktiviert E-CHECK und Enemys nach ausgewählter Schwierigkeit
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Globals.IntersectionTimer1 += 1;
            Globals.IntersectionTimer2 += 1;
            Globals.IntersectionTimer3 += 1;
            Globals.IntersectionTimer4 += 1;
            Globals.IntersectionTimer5 += 1;
            Globals.IntersectionTimer6 += 1;
            Globals.IntersectionTimer7 += 1;
            Globals.IntersectionTimer8 += 1;
            switch (Globals.Difficulty)
            {
                case 1:
                    E1Check();
                    E2Check();
                    E3Check();
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    E4.Visible = false;
                    E5.Visible = false;
                    E6.Visible = false;
                    E7.Visible = false;
                    E8.Visible = false;
                    break;
                case 2:
                    E1Check();
                    E2Check();
                    E3Check();
                    E4Check();
                    E5Check();
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    E4.Visible = true;
                    E5.Visible = true;
                    E6.Visible = false;
                    E7.Visible = false;
                    E8.Visible = false;
                    break;
                case 3:
                    E1Check();
                    E2Check();
                    E3Check();
                    E4Check();
                    E5Check();
                    E6Check();
                    E7Check();
                    E8Check();
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    E4.Visible = true;
                    E5.Visible = true;
                    E6.Visible = true;
                    E7.Visible = true;
                    E8.Visible = true;
                    break;
            }

            //HEALTH-Abfragen 
            if (Globals.E1Health <= 0)
            {
                E1.Location = new Point(0, 0); E1.Size = new Size(1, 1);
                Globals.E1Alive = false;
            }
            if (Globals.E2Health <= 0)
            {
                E2.Location = new Point(0, 0); E2.Size = new Size(1, 1);
                Globals.E2Alive = false;
            }
            if (Globals.E3Health <= 0)
            {
                E3.Location = new Point(0, 0); E3.Size = new Size(1, 1);
                Globals.E3Alive = false;
            }
            if (Globals.E4Health <= 0)
            {
                E4.Location = new Point(0, 0); E4.Size = new Size(1, 1);
                Globals.E4Alive = false;
            }
            if (Globals.E5Health <= 0)
            {
                E5.Location = new Point(0, 0); E5.Size = new Size(1, 1);
                Globals.E5Alive = false;
            }
            if (Globals.E6Health <= 0)
            {
                E6.Location = new Point(0, 0); E6.Size = new Size(1, 1);
                Globals.E6Alive = false;
            }
            if (Globals.E7Health <= 0)
            {
                E7.Location = new Point(0, 0); E7.Size = new Size(1, 1);
                Globals.E7Alive = false;
            }
            if (Globals.E8Health <= 0)
            {
                E8.Location = new Point(0, 0); E8.Size = new Size(1, 1);
                Globals.E8Alive = false;
            }
            ShowHealth();
            if (Globals.PlayerHealth <= 0)
            {
                GameLose();
            }
        }


        // Win-Lose-Funktionen
        public void GameLose()
        {
            GameTimer.Enabled = false;
            GameTimer2.Enabled = false;
            GameTimer3.Enabled = false;
            MenuUI();
            E1.Visible = false;
            E2.Visible = false;
            E3.Visible = false;
            E4.Visible = false;
            E5.Visible = false;
            E6.Visible = false;
            E7.Visible = false;
            E8.Visible = false;
            MessageBox.Show("Verloren! Du wurdest getötet!", "Schade!", MessageBoxButtons.OK);
            Player.Left = 400;
            Player.Top = 400;
            PlayerLabel.Left = 450;
            PlayerLabel.Top = 450;
            Globals.PlayerHealth = 100;
            Application.Exit();

        }
        public void GameWin()
        {
            GameTimer.Enabled = false;
            GameTimer2.Enabled = false;
            GameTimer3.Enabled = false;
            MenuUI();
            E1.Visible = false;
            E2.Visible = false;
            E3.Visible = false;
            E4.Visible = false;
            E5.Visible = false;
            E6.Visible = false;
            E7.Visible = false;
            E8.Visible = false;
            MessageBox.Show("Gewonnen! Du hast überlebt!", "Yuhuu!", MessageBoxButtons.OK);
            Player.Left = 400;
            Player.Top = 400;
            PlayerLabel.Left = 450;
            PlayerLabel.Top = 450;
            Application.Exit();
        }


        // Timer2-Tick, Wann soll GameWin() ausgeführt werden
        private void GameTimer2_Tick(object sender, EventArgs e)
        {
            Globals.GameCooldown -= 1;
            LabelTimer.Text = Globals.GameCooldown.ToString();
            if (Globals.GameCooldown <= 0)
            {
                GameWin();
            }

            switch (Globals.Difficulty)
            {
                case 1:
                    if (!Globals.E1Alive && !Globals.E2Alive && !Globals.E3Alive)
                    {
                        GameWin();
                    }
                    break;
                case 2:
                    if (!Globals.E1Alive && !Globals.E2Alive && !Globals.E3Alive && !Globals.E4Alive && !Globals.E5Alive)
                    {
                        GameWin();
                    }
                    break;
                case 3:
                    if (!Globals.E1Alive && !Globals.E2Alive && !Globals.E3Alive && !Globals.E4Alive && !Globals.E5Alive && !Globals.E6Alive && !Globals.E7Alive && !Globals.E8Alive)
                    {
                        GameWin();
                    }
                    break;

            }

        }


        // E-CHECK, Movement + wenn Enemy eine Wand trifft prallt es ab und verliert 10 Lebenspunkte
        // je nach Schwierigkeit verliert der Spieler Lebenspunkte (8, 12, 15) bei Collision, sowie Enemy(15, 12, 8)
        public void E1Check()
        {
            E1.Top += Globals.SpeedY1;
            E1.Left += Globals.SpeedX1;
            if (E1.Top < 0 ^ E1.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY1 = -Globals.SpeedY1;
                Globals.E1Health = Globals.E1Health - 10;
            }
            if (E1.Right > this.ClientSize.Width ^ E1.Left < 0)
            {
                Globals.SpeedX1 = -Globals.SpeedX1;
                Globals.E1Health = Globals.E1Health - 10;
            }

            if (E1.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX1 = -Globals.SpeedX1;
                Globals.SpeedY1 = -Globals.SpeedY1;
                if (Globals.IntersectionTimer1 >= 100)
                {
                    Globals.IntersectionTimer1 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E1Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E1Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E1Health -= 8;
                            break;
                    }
                }
            }
        }
        public void E2Check()
        {
            E2.Top += Globals.SpeedY2;
            E2.Left += Globals.SpeedX2;
            if (E2.Top < 0 ^ E2.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY2 = -Globals.SpeedY2;
                Globals.E2Health = Globals.E2Health - 10;
            }
            if (E2.Right > this.ClientSize.Width ^ E2.Left < 0)
            {
                Globals.SpeedX2 = -Globals.SpeedX2;
                Globals.E2Health = Globals.E2Health - 10;
            }
            if (E2.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX2 = -Globals.SpeedX2;
                Globals.SpeedY2 = -Globals.SpeedY2;
                if (Globals.IntersectionTimer2 >= 100)
                {
                    Globals.IntersectionTimer2 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E2Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E2Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E2Health -= 8;
                            break;
                    }
                }
            }
        }
        public void E3Check()
        {
            E3.Top += Globals.SpeedY3;
            E3.Left += Globals.SpeedX3;
            if (E3.Top < 0 ^ E3.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY3 = -Globals.SpeedY3;
                Globals.E3Health = Globals.E3Health - 10;
            }
            if (E3.Right > this.ClientSize.Width ^ E3.Left < 0)
            {
                Globals.SpeedX3 = -Globals.SpeedX3;
                Globals.E3Health = Globals.E3Health - 10;
            }
            if (E3.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX3 = -Globals.SpeedX3;
                Globals.SpeedY3 = -Globals.SpeedY3;
                if (Globals.IntersectionTimer3 >= 100)
                {
                    Globals.IntersectionTimer3 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E3Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E3Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E3Health -= 8;
                            break;
                    }
                }
            }
        }
        public void E4Check()
        {
            E4.Top += Globals.SpeedY4;
            E4.Left += Globals.SpeedX4;
            if (E4.Top < 0 ^ E4.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY4 = -Globals.SpeedY4;
                Globals.E4Health = Globals.E4Health - 10;
            }
            if (E4.Right > this.ClientSize.Width ^ E4.Left < 0)
            {
                Globals.SpeedX4 = -Globals.SpeedX4;
                Globals.E4Health = Globals.E4Health - 10;
            }
            if (E4.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX4 = -Globals.SpeedX4;
                Globals.SpeedY4 = -Globals.SpeedY4;
                if (Globals.IntersectionTimer4 >= 100)
                {
                    Globals.IntersectionTimer4 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E4Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E4Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E4Health -= 8;
                            break;
                    }
                }
            }
        }
        public void E5Check()
        {
            E5.Top += Globals.SpeedY5;
            E5.Left += Globals.SpeedX5;
            if (E5.Top < 0 ^ E5.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY5 = -Globals.SpeedY5;
                Globals.E5Health = Globals.E5Health - 10;
            }
            if (E5.Right > this.ClientSize.Width ^ E5.Left < 0)
            {
                Globals.SpeedX5 = -Globals.SpeedX5;
                Globals.E5Health = Globals.E5Health - 10;
            }
            if (E5.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX5 = -Globals.SpeedX5;
                Globals.SpeedY5 = -Globals.SpeedY5;
                if (Globals.IntersectionTimer5 >= 100)
                {
                    Globals.IntersectionTimer5 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E5Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E5Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E5Health -= 8;
                            break;
                    }
                }
            }

        }
        public void E6Check()
        {
            E6.Top += Globals.SpeedY6;
            E6.Left += Globals.SpeedX6;
            if (E6.Top < 0 ^ E6.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY6 = -Globals.SpeedY6;
                Globals.E6Health = Globals.E6Health - 10;
            }
            if (E6.Right > this.ClientSize.Width ^ E6.Left < 0)
            {
                Globals.SpeedX6 = -Globals.SpeedX6;
                Globals.E6Health = Globals.E6Health - 10;
            }
            if (E6.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX6 = -Globals.SpeedX6;
                Globals.SpeedY6 = -Globals.SpeedY6;
                if (Globals.IntersectionTimer6 >= 100)
                {
                    Globals.IntersectionTimer6 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E6Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E6Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E6Health -= 8;
                            break;
                    }
                }
            }

        }
        public void E7Check()
        {
            E7.Top += Globals.SpeedY7;
            E7.Left += Globals.SpeedX7;
            if (E7.Top < 0 ^ E7.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY7 = -Globals.SpeedY7;
                Globals.E7Health = Globals.E7Health - 10;
            }
            if (E7.Right > this.ClientSize.Width ^ E7.Left < 0)
            {
                Globals.SpeedX7 = -Globals.SpeedX7;
                Globals.E7Health = Globals.E7Health - 10;
            }
            if (E7.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX7 = -Globals.SpeedX7;
                Globals.SpeedY7 = -Globals.SpeedY7;
                if (Globals.IntersectionTimer7 >= 100)
                {
                    Globals.IntersectionTimer7 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E7Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E7Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E7Health -= 8;
                            break;
                    }
                }
            }
        }
        public void E8Check()
        {
            E8.Top += Globals.SpeedY8;
            E8.Left += Globals.SpeedX8;
            if (E8.Top < 0 ^ E8.Bottom > this.ClientSize.Height)
            {
                Globals.SpeedY8 = -Globals.SpeedY8;
                Globals.E8Health = Globals.E8Health - 10;
            }
            if (E8.Right > this.ClientSize.Width ^ E8.Left < 0)
            {
                Globals.SpeedX8 = -Globals.SpeedX8;
                Globals.E8Health = Globals.E8Health - 10;
            }
            if (E8.Bounds.IntersectsWith(Player.Bounds))
            {
                Globals.SpeedX8 = -Globals.SpeedX8;
                Globals.SpeedY8 = -Globals.SpeedY8;
                if (Globals.IntersectionTimer8 >= 100)
                {
                    Globals.IntersectionTimer8 = 0;
                    switch (Globals.Difficulty)
                    {
                        case 1:
                            Globals.PlayerHealth -= 8;
                            Globals.E8Health -= 15;
                            break;
                        case 2:
                            Globals.PlayerHealth -= 12;
                            Globals.E8Health -= 12;
                            break;
                        case 3:
                            Globals.PlayerHealth -= 15;
                            Globals.E8Health -= 8;
                            break;
                    }
                }
            }
        }


        // Health anzeigen
        public void ShowHealth()
        {
            E1.Text = Globals.E1Health.ToString();
            E2.Text = Globals.E2Health.ToString();
            E3.Text = Globals.E3Health.ToString();
            E4.Text = Globals.E4Health.ToString();
            E5.Text = Globals.E5Health.ToString();
            E6.Text = Globals.E6Health.ToString();
            E7.Text = Globals.E7Health.ToString();
            E8.Text = Globals.E8Health.ToString();
            PlayerLabel.Text = Globals.PlayerHealth.ToString();
        }


        // Buttons (Start, Beenden, Pause, Weiter)
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            PauseUI();
            GameTimer.Enabled = false;
            GameTimer2.Enabled = false;
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Globals.Boost = true;
            Globals.PlayerHealth = 100;
            PlayerLabel.Text = Globals.PlayerHealth.ToString();
            GameTimer.Enabled = true;
            GameTimer2.Enabled = true;
            CreateRandom();
            GameUI();
            CreateColors();
        }
        private void ButtonStop_Click(object sender, EventArgs e)
        {

            switch (Globals.Difficulty)
            {
                case 1:
                    Globals.GameCooldown = 31;
                    break;
                case 2:
                    Globals.GameCooldown = 41;
                    break;
                case 3:
                    Globals.GameCooldown = 51;
                    break;

            }
            Globals.Boost = true;
            MenuUI();
            Globals.PlayerHealth = 100;
            Player.Left = 400;
            Player.Top = 400;
            PlayerLabel.Left = 450;
            PlayerLabel.Top = 450;
            DifficultyBox.Visible = true;
            E1.Location = new Point(429, 1);
            E2.Location = new Point(429, 1);
            E3.Location = new Point(429, 1);
            E4.Location = new Point(429, 1);
            E5.Location = new Point(429, 1);
            E6.Location = new Point(429, 1);
            E7.Location = new Point(429, 1);
            E8.Location = new Point(429, 1);
        }
        private void ButtonResume_Click_1(object sender, EventArgs e)
        {
            GameUI();
            GameTimer.Enabled = true;
            GameTimer2.Enabled = true;
        }


        //UI wechsel (Spiel, Pause, Menü)
        public void GameUI()
        {
            ButtonStart.Visible = false;
            ButtonColor1.Visible = false;
            DifficultyLabel.Visible = false;
            ButtonName.Visible = false;
            ButtonColor2.Visible = false;
            DifficultyBox.Visible = false;
            ButtonPause.Visible = true;
            ButtonColorReroll.Visible = true;
            LabelTimer.Visible = true;
            ButtonStop.Visible = false;
            ButtonResume.Visible = false;
            GameTimer3.Enabled = true;
            ButtonHelp.Visible = false;
        }
        public void MenuUI()
        {
            ButtonStart.Visible = true;
            ButtonColor1.Visible = true;
            ButtonColor2.Visible = true;
            DifficultyLabel.Visible = false;
            ButtonName.Visible = true;
            DifficultyBox.Visible = true;
            ButtonPause.Visible = false;
            GameTimer.Enabled = false;
            ButtonColorReroll.Visible = false;
            LabelTimer.Visible = false;
            ButtonStop.Visible = false;
            ButtonResume.Visible = false;
            E1.Visible = false;
            E2.Visible = false;
            E3.Visible = false;
            E4.Visible = false;
            E5.Visible = false;
            E6.Visible = false;
            E7.Visible = false;
            E8.Visible = false;
            GameTimer3.Enabled = false;
            ButtonHelp.Visible = true;
        }
        public void PauseUI()
        {
            ButtonStart.Visible = true;
            ButtonColor1.Visible = true;
            ButtonColor2.Visible = true;
            ButtonName.Visible = true;
            ButtonPause.Visible = false;
            GameTimer.Enabled = false;
            ButtonColorReroll.Visible = false;
            LabelTimer.Visible = true;
            ButtonStop.Visible = true;
            ButtonResume.Visible = true;
            GameTimer3.Enabled = false;
            ButtonHelp.Visible = true;
        }


        //SETUP-BUTTONS   
        private void ButtonName_Click(object sender, EventArgs e)
        {
            PlayerSize();

        }
        public void PlayerSize()
        {
            string name = Interaction.InputBox("Nickname wählen:");
            Player.Text = name;
            if (name.Length > 0)
            {
                int WantedSize = 50;
                int width = Player.DisplayRectangle.Width - 3;
                int height = Player.DisplayRectangle.Height - 3;
                using (Graphics gr = Player.CreateGraphics())
                {
                    for (int i = 1; i <= 50; i++)
                    {
                        using (Font TestFont = new Font(Player.Font.FontFamily, i))
                        {
                            SizeF text_size = gr.MeasureString(name, TestFont);
                            if ((text_size.Width > width) || (text_size.Height > height))
                            {
                                WantedSize = i - 1;
                                break;
                            }
                        }
                    }
                }
                Player.Font = new Font(Player.Font.FontFamily, WantedSize);
            }
        }
        private void DifficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DifficultyBox.SelectedIndex;
            switch (index)
            {
                case 0:
                    Globals.Difficulty = 1;
                    break;
                case 1:
                    Globals.Difficulty = 2;
                    break;
                case 2:
                    Globals.Difficulty = 3;
                    break;
            }

            switch (Globals.Difficulty)
            {
                case 1:
                    Globals.GameCooldown = 31;
                    break;
                case 2:
                    Globals.GameCooldown = 41;
                    break;
                case 3:
                    Globals.GameCooldown = 61;
                    break;
            }


        }
        private void ButtonColor1_Click(object sender, EventArgs e)
        {
            ColorDialog ColorChoice = new ColorDialog();
            if (ColorChoice.ShowDialog() == DialogResult.OK)
                Player.BackColor = ColorChoice.Color;
        }
        private void ButtonColor2_Click(object sender, EventArgs e)
        {
            ColorDialog ColorChoice = new ColorDialog();
            if (ColorChoice.ShowDialog() == DialogResult.OK)
                Player.ForeColor = ColorChoice.Color;
        }
        private void ButtonColorReroll_Click(object sender, EventArgs e)
        {
            CreateColors();
            CreateRandom();
        }


        //STEUERUNG
        private void GameTimer3_Tick(object sender, EventArgs e)
        {
            if (Globals.moveLeft == true && Player.Left >= 0)
            {
                Player.Left -= Globals.PlayerSpeed;
                PlayerLabel.Left -= Globals.PlayerSpeed;
            }
            if (Globals.moveRight == true && Player.Right <= 860)
            {
                Player.Left += Globals.PlayerSpeed;
                PlayerLabel.Left += Globals.PlayerSpeed;
            }
            if (Globals.moveUp == true && Player.Top >= 0)
            {
                Player.Top -= Globals.PlayerSpeed;
                PlayerLabel.Top -= Globals.PlayerSpeed;
            }
            if (Globals.moveDown == true && Player.Top <= 495)
            {
                Player.Top += Globals.PlayerSpeed;
                PlayerLabel.Top += Globals.PlayerSpeed;
            }
        }
        private void FormDestroyTheCubes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Globals.moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                Globals.moveRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                Globals.moveUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                Globals.moveDown = true;
            }
        }
        private void FormDestroyTheCubes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Globals.moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Globals.moveRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                Globals.moveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                Globals.moveDown = false;
            }

        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es werden (je nach Schwierigkeit) Gegner erscheinen. Sie bewegen sich von alleine. Du musst ihnen mit den WASD-Tasten ausweichen!", "Hilfe", MessageBoxButtons.OK);
            MessageBox.Show("Wenn die Gegner gegen eine Wand treffen, verlieren sie Leben. Wenn die Gegner gegen dich treffen, verlierst auch du Leben!", "Hilfe", MessageBoxButtons.OK);
            MessageBox.Show("Wenn alle Gegner ihre Lebenspunkte verloren haben oder der Timer oben abläuft, gewinnst du!", "Hilfe", MessageBoxButtons.OK);
            MessageBox.Show("Wenn du keine Lebenspunkte mehr übrig hast, verlierst du!", "Hilfe", MessageBoxButtons.OK);
            MessageBox.Show("Die Schwierigkeit kannst du oben rechts einstellen.", "Hilfe", MessageBoxButtons.OK);
            MessageBox.Show("Du kannst über die Buttons oben links noch deinen Spieler anpassen!", "Hilfe", MessageBoxButtons.OK);
        }
    }
}
