
namespace GameCollection
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbA1 = new System.Windows.Forms.PictureBox();
            this.pbB1 = new System.Windows.Forms.PictureBox();
            this.pbC1 = new System.Windows.Forms.PictureBox();
            this.pbA2 = new System.Windows.Forms.PictureBox();
            this.pbB2 = new System.Windows.Forms.PictureBox();
            this.pbC2 = new System.Windows.Forms.PictureBox();
            this.pbA3 = new System.Windows.Forms.PictureBox();
            this.pbB3 = new System.Windows.Forms.PictureBox();
            this.pbC3 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOWins = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblAutoRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbA1
            // 
            this.pbA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbA1.Location = new System.Drawing.Point(280, 120);
            this.pbA1.Margin = new System.Windows.Forms.Padding(8);
            this.pbA1.Name = "pbA1";
            this.pbA1.Size = new System.Drawing.Size(75, 75);
            this.pbA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA1.TabIndex = 0;
            this.pbA1.TabStop = false;
            this.pbA1.Click += new System.EventHandler(this.pbA1_Click);
            // 
            // pbB1
            // 
            this.pbB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbB1.Location = new System.Drawing.Point(371, 120);
            this.pbB1.Margin = new System.Windows.Forms.Padding(8);
            this.pbB1.Name = "pbB1";
            this.pbB1.Size = new System.Drawing.Size(75, 75);
            this.pbB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbB1.TabIndex = 1;
            this.pbB1.TabStop = false;
            this.pbB1.Click += new System.EventHandler(this.pbB1_Click);
            // 
            // pbC1
            // 
            this.pbC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbC1.Location = new System.Drawing.Point(462, 120);
            this.pbC1.Margin = new System.Windows.Forms.Padding(8);
            this.pbC1.Name = "pbC1";
            this.pbC1.Size = new System.Drawing.Size(75, 75);
            this.pbC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbC1.TabIndex = 2;
            this.pbC1.TabStop = false;
            this.pbC1.Click += new System.EventHandler(this.pbC1_Click);
            // 
            // pbA2
            // 
            this.pbA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbA2.Location = new System.Drawing.Point(280, 211);
            this.pbA2.Margin = new System.Windows.Forms.Padding(8);
            this.pbA2.Name = "pbA2";
            this.pbA2.Size = new System.Drawing.Size(75, 75);
            this.pbA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA2.TabIndex = 3;
            this.pbA2.TabStop = false;
            this.pbA2.Click += new System.EventHandler(this.pbA2_Click);
            // 
            // pbB2
            // 
            this.pbB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbB2.Location = new System.Drawing.Point(371, 211);
            this.pbB2.Margin = new System.Windows.Forms.Padding(8);
            this.pbB2.Name = "pbB2";
            this.pbB2.Size = new System.Drawing.Size(75, 75);
            this.pbB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbB2.TabIndex = 4;
            this.pbB2.TabStop = false;
            this.pbB2.Click += new System.EventHandler(this.pbB2_Click);
            // 
            // pbC2
            // 
            this.pbC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbC2.Location = new System.Drawing.Point(462, 211);
            this.pbC2.Margin = new System.Windows.Forms.Padding(8);
            this.pbC2.Name = "pbC2";
            this.pbC2.Size = new System.Drawing.Size(75, 75);
            this.pbC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbC2.TabIndex = 5;
            this.pbC2.TabStop = false;
            this.pbC2.Click += new System.EventHandler(this.pbC2_Click);
            // 
            // pbA3
            // 
            this.pbA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbA3.Location = new System.Drawing.Point(280, 302);
            this.pbA3.Margin = new System.Windows.Forms.Padding(8);
            this.pbA3.Name = "pbA3";
            this.pbA3.Size = new System.Drawing.Size(75, 75);
            this.pbA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA3.TabIndex = 6;
            this.pbA3.TabStop = false;
            this.pbA3.Click += new System.EventHandler(this.pbA3_Click);
            // 
            // pbB3
            // 
            this.pbB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbB3.Location = new System.Drawing.Point(371, 302);
            this.pbB3.Margin = new System.Windows.Forms.Padding(8);
            this.pbB3.Name = "pbB3";
            this.pbB3.Size = new System.Drawing.Size(75, 75);
            this.pbB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbB3.TabIndex = 7;
            this.pbB3.TabStop = false;
            this.pbB3.Click += new System.EventHandler(this.pbB3_Click);
            // 
            // pbC3
            // 
            this.pbC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pbC3.Location = new System.Drawing.Point(462, 302);
            this.pbC3.Margin = new System.Windows.Forms.Padding(8);
            this.pbC3.Name = "pbC3";
            this.pbC3.Size = new System.Drawing.Size(75, 75);
            this.pbC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbC3.TabIndex = 8;
            this.pbC3.TabStop = false;
            this.pbC3.Click += new System.EventHandler(this.pbC3_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnRefresh.Location = new System.Drawing.Point(280, 430);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(257, 36);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblOWins.Location = new System.Drawing.Point(52, 75);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(66, 24);
            this.lblOWins.TabIndex = 10;
            this.lblOWins.Text = "label1";
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblXWins.Location = new System.Drawing.Point(52, 120);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(66, 24);
            this.lblXWins.TabIndex = 11;
            this.lblXWins.Text = "label2";
            // 
            // lblAutoRefresh
            // 
            this.lblAutoRefresh.AutoSize = true;
            this.lblAutoRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblAutoRefresh.Location = new System.Drawing.Point(24, 496);
            this.lblAutoRefresh.Name = "lblAutoRefresh";
            this.lblAutoRefresh.Size = new System.Drawing.Size(0, 24);
            this.lblAutoRefresh.TabIndex = 12;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(852, 529);
            this.Controls.Add(this.lblAutoRefresh);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.lblOWins);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pbC3);
            this.Controls.Add(this.pbB3);
            this.Controls.Add(this.pbA3);
            this.Controls.Add(this.pbC2);
            this.Controls.Add(this.pbB2);
            this.Controls.Add(this.pbA2);
            this.Controls.Add(this.pbC1);
            this.Controls.Add(this.pbB1);
            this.Controls.Add(this.pbA1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.pbA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbA1;
        private System.Windows.Forms.PictureBox pbB1;
        private System.Windows.Forms.PictureBox pbC1;
        private System.Windows.Forms.PictureBox pbA2;
        private System.Windows.Forms.PictureBox pbB2;
        private System.Windows.Forms.PictureBox pbC2;
        private System.Windows.Forms.PictureBox pbA3;
        private System.Windows.Forms.PictureBox pbB3;
        private System.Windows.Forms.PictureBox pbC3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOWins;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblAutoRefresh;
    }
}