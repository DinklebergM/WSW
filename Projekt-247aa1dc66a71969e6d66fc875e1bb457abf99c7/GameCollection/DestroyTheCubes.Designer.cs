
namespace DestroyTheCubes
{
    partial class FormDestroyTheCubes
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonColor1 = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonName = new System.Windows.Forms.Button();
            this.DifficultyBox = new System.Windows.Forms.ComboBox();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.E1 = new System.Windows.Forms.Button();
            this.E2 = new System.Windows.Forms.Button();
            this.E3 = new System.Windows.Forms.Button();
            this.E5 = new System.Windows.Forms.Button();
            this.E4 = new System.Windows.Forms.Button();
            this.E6 = new System.Windows.Forms.Button();
            this.E8 = new System.Windows.Forms.Button();
            this.E7 = new System.Windows.Forms.Button();
            this.ButtonColor2 = new System.Windows.Forms.Button();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.ButtonColorReroll = new System.Windows.Forms.Button();
            this.GameTimer2 = new System.Windows.Forms.Timer(this.components);
            this.LabelTimer = new System.Windows.Forms.Label();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonResume = new System.Windows.Forms.Button();
            this.GameTimer3 = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.White;
            this.ButtonStart.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonStart.Location = new System.Drawing.Point(740, 499);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(112, 30);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonColor1
            // 
            this.ButtonColor1.BackColor = System.Drawing.Color.White;
            this.ButtonColor1.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonColor1.Location = new System.Drawing.Point(2, 29);
            this.ButtonColor1.Name = "ButtonColor1";
            this.ButtonColor1.Size = new System.Drawing.Size(163, 27);
            this.ButtonColor1.TabIndex = 3;
            this.ButtonColor1.Text = "Hintergrundfarbe wählen";
            this.ButtonColor1.UseVisualStyleBackColor = false;
            this.ButtonColor1.Click += new System.EventHandler(this.ButtonColor1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ButtonName
            // 
            this.ButtonName.BackColor = System.Drawing.Color.White;
            this.ButtonName.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonName.Location = new System.Drawing.Point(2, 3);
            this.ButtonName.Name = "ButtonName";
            this.ButtonName.Size = new System.Drawing.Size(128, 26);
            this.ButtonName.TabIndex = 9;
            this.ButtonName.Text = "Namen eingeben";
            this.ButtonName.UseVisualStyleBackColor = false;
            this.ButtonName.Click += new System.EventHandler(this.ButtonName_Click);
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.FormattingEnabled = true;
            this.DifficultyBox.Items.AddRange(new object[] {
            "Einfach (3 Gegner, 8 Schaden)",
            "Normal (5 Gegner, 12 Schaden)",
            "Schwer (8 Gegner, 15 Schaden)"});
            this.DifficultyBox.Location = new System.Drawing.Point(634, 4);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(214, 24);
            this.DifficultyBox.TabIndex = 10;
            this.DifficultyBox.SelectedIndexChanged += new System.EventHandler(this.DifficultyBox_SelectedIndexChanged);
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.White;
            this.ButtonPause.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonPause.Location = new System.Drawing.Point(740, 467);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(112, 30);
            this.ButtonPause.TabIndex = 11;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // E1
            // 
            this.E1.BackColor = System.Drawing.Color.White;
            this.E1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E1.ForeColor = System.Drawing.Color.Red;
            this.E1.Location = new System.Drawing.Point(429, 1);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(75, 75);
            this.E1.TabIndex = 12;
            this.E1.UseVisualStyleBackColor = false;
            // 
            // E2
            // 
            this.E2.BackColor = System.Drawing.Color.White;
            this.E2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E2.ForeColor = System.Drawing.Color.Red;
            this.E2.Location = new System.Drawing.Point(429, 1);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(75, 75);
            this.E2.TabIndex = 13;
            this.E2.UseVisualStyleBackColor = false;
            // 
            // E3
            // 
            this.E3.BackColor = System.Drawing.Color.White;
            this.E3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E3.ForeColor = System.Drawing.Color.Red;
            this.E3.Location = new System.Drawing.Point(429, 1);
            this.E3.Name = "E3";
            this.E3.Size = new System.Drawing.Size(75, 75);
            this.E3.TabIndex = 14;
            this.E3.UseVisualStyleBackColor = false;
            // 
            // E5
            // 
            this.E5.BackColor = System.Drawing.Color.White;
            this.E5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E5.ForeColor = System.Drawing.Color.Red;
            this.E5.Location = new System.Drawing.Point(429, 1);
            this.E5.Name = "E5";
            this.E5.Size = new System.Drawing.Size(75, 75);
            this.E5.TabIndex = 15;
            this.E5.UseVisualStyleBackColor = false;
            // 
            // E4
            // 
            this.E4.BackColor = System.Drawing.Color.White;
            this.E4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E4.ForeColor = System.Drawing.Color.Red;
            this.E4.Location = new System.Drawing.Point(429, 3);
            this.E4.Name = "E4";
            this.E4.Size = new System.Drawing.Size(75, 75);
            this.E4.TabIndex = 16;
            this.E4.UseVisualStyleBackColor = false;
            // 
            // E6
            // 
            this.E6.BackColor = System.Drawing.Color.White;
            this.E6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E6.ForeColor = System.Drawing.Color.Red;
            this.E6.Location = new System.Drawing.Point(429, 1);
            this.E6.Name = "E6";
            this.E6.Size = new System.Drawing.Size(75, 75);
            this.E6.TabIndex = 17;
            this.E6.UseVisualStyleBackColor = false;
            // 
            // E8
            // 
            this.E8.BackColor = System.Drawing.Color.White;
            this.E8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E8.ForeColor = System.Drawing.Color.Red;
            this.E8.Location = new System.Drawing.Point(429, 1);
            this.E8.Name = "E8";
            this.E8.Size = new System.Drawing.Size(75, 75);
            this.E8.TabIndex = 18;
            this.E8.UseVisualStyleBackColor = false;
            // 
            // E7
            // 
            this.E7.BackColor = System.Drawing.Color.White;
            this.E7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E7.ForeColor = System.Drawing.Color.Red;
            this.E7.Location = new System.Drawing.Point(429, 1);
            this.E7.Name = "E7";
            this.E7.Size = new System.Drawing.Size(75, 75);
            this.E7.TabIndex = 19;
            this.E7.UseVisualStyleBackColor = false;
            // 
            // ButtonColor2
            // 
            this.ButtonColor2.BackColor = System.Drawing.Color.White;
            this.ButtonColor2.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonColor2.Location = new System.Drawing.Point(2, 56);
            this.ButtonColor2.Name = "ButtonColor2";
            this.ButtonColor2.Size = new System.Drawing.Size(128, 27);
            this.ButtonColor2.TabIndex = 20;
            this.ButtonColor2.Text = "Schriftfarbe wählen";
            this.ButtonColor2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ButtonColor2.UseVisualStyleBackColor = false;
            this.ButtonColor2.Click += new System.EventHandler(this.ButtonColor2_Click);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(350, 489);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(0, 16);
            this.PlayerLabel.TabIndex = 21;
            // 
            // ButtonColorReroll
            // 
            this.ButtonColorReroll.BackColor = System.Drawing.Color.White;
            this.ButtonColorReroll.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonColorReroll.Location = new System.Drawing.Point(719, 498);
            this.ButtonColorReroll.Name = "ButtonColorReroll";
            this.ButtonColorReroll.Size = new System.Drawing.Size(133, 30);
            this.ButtonColorReroll.TabIndex = 22;
            this.ButtonColorReroll.Text = "Gegner neu laden";
            this.ButtonColorReroll.UseVisualStyleBackColor = false;
            this.ButtonColorReroll.Click += new System.EventHandler(this.ButtonColorReroll_Click);
            // 
            // GameTimer2
            // 
            this.GameTimer2.Interval = 1000;
            this.GameTimer2.Tick += new System.EventHandler(this.GameTimer2_Tick);
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Location = new System.Drawing.Point(3, 511);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(0, 16);
            this.LabelTimer.TabIndex = 23;
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.White;
            this.ButtonStop.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonStop.Location = new System.Drawing.Point(740, 497);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(112, 30);
            this.ButtonStop.TabIndex = 24;
            this.ButtonStop.Text = "Beenden";
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonResume
            // 
            this.ButtonResume.BackColor = System.Drawing.Color.White;
            this.ButtonResume.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonResume.Location = new System.Drawing.Point(740, 467);
            this.ButtonResume.Name = "ButtonResume";
            this.ButtonResume.Size = new System.Drawing.Size(112, 30);
            this.ButtonResume.TabIndex = 25;
            this.ButtonResume.Text = "Weiter";
            this.ButtonResume.UseVisualStyleBackColor = false;
            this.ButtonResume.Click += new System.EventHandler(this.ButtonResume_Click_1);
            // 
            // GameTimer3
            // 
            this.GameTimer3.Enabled = true;
            this.GameTimer3.Interval = 10;
            this.GameTimer3.Tick += new System.EventHandler(this.GameTimer3_Tick);
            // 
            // Player
            // 
            this.Player.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.ForeColor = System.Drawing.Color.Red;
            this.Player.Location = new System.Drawing.Point(392, 452);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 50);
            this.Player.TabIndex = 27;
            this.Player.Text = "You";
            this.Player.UseVisualStyleBackColor = false;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.White;
            this.ButtonHelp.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonHelp.Location = new System.Drawing.Point(2, 497);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(112, 30);
            this.ButtonHelp.TabIndex = 28;
            this.ButtonHelp.Text = "Hilfe/Tutorial";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DifficultyLabel.Location = new System.Drawing.Point(664, 34);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(152, 16);
            this.DifficultyLabel.TabIndex = 29;
            this.DifficultyLabel.Text = "^ Schwierigkeit wählen ^";
            // 
            // FormDestroyTheCubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(852, 529);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ButtonResume);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.ButtonColorReroll);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.ButtonColor2);
            this.Controls.Add(this.E7);
            this.Controls.Add(this.E8);
            this.Controls.Add(this.E6);
            this.Controls.Add(this.E4);
            this.Controls.Add(this.E5);
            this.Controls.Add(this.E3);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.ButtonName);
            this.Controls.Add(this.ButtonColor1);
            this.Controls.Add(this.ButtonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDestroyTheCubes";
            this.Text = "FormDestroyTheCubes";
            this.Load += new System.EventHandler(this.FormDestroyTheCubes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDestroyTheCubes_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDestroyTheCubes_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonColor1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button ButtonName;
        private System.Windows.Forms.ComboBox DifficultyBox;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.Button E1;
        private System.Windows.Forms.Button E2;
        private System.Windows.Forms.Button E3;
        private System.Windows.Forms.Button E5;
        private System.Windows.Forms.Button E4;
        private System.Windows.Forms.Button E6;
        private System.Windows.Forms.Button E8;
        private System.Windows.Forms.Button E7;
        private System.Windows.Forms.Button ButtonColor2;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Button ButtonColorReroll;
        private System.Windows.Forms.Timer GameTimer2;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonResume;
        private System.Windows.Forms.Timer GameTimer3;
        private System.Windows.Forms.Button Player;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Label DifficultyLabel;
    }
}

