
namespace WSWHotelManagement
{
    partial class frmCheckOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVrooms = new System.Windows.Forms.DataGridView();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVrooms
            // 
            this.DGVrooms.AllowUserToAddRows = false;
            this.DGVrooms.AllowUserToDeleteRows = false;
            this.DGVrooms.AllowUserToResizeColumns = false;
            this.DGVrooms.AllowUserToResizeRows = false;
            this.DGVrooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVrooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVrooms.BackgroundColor = System.Drawing.Color.White;
            this.DGVrooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVrooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVrooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVrooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVrooms.EnableHeadersVisualStyles = false;
            this.DGVrooms.GridColor = System.Drawing.Color.DimGray;
            this.DGVrooms.Location = new System.Drawing.Point(36, 126);
            this.DGVrooms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DGVrooms.Name = "DGVrooms";
            this.DGVrooms.ReadOnly = true;
            this.DGVrooms.RowHeadersVisible = false;
            this.DGVrooms.ShowCellToolTips = false;
            this.DGVrooms.ShowEditingIcon = false;
            this.DGVrooms.ShowRowErrors = false;
            this.DGVrooms.Size = new System.Drawing.Size(1179, 520);
            this.DGVrooms.TabIndex = 1;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(31, 652);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(78, 29);
            this.lblLastname.TabIndex = 31;
            this.lblLastname.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(37, 685);
            this.tbName.Margin = new System.Windows.Forms.Padding(15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(259, 34);
            this.tbName.TabIndex = 30;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(320, 652);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(78, 29);
            this.lblRoomNumber.TabIndex = 33;
            this.lblRoomNumber.Text = "Room";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(326, 685);
            this.tbRoomNumber.Margin = new System.Windows.Forms.Padding(15);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(259, 34);
            this.tbRoomNumber.TabIndex = 32;
            this.tbRoomNumber.TextChanged += new System.EventHandler(this.tbRoomNumber_TextChanged);
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(609, 653);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(181, 29);
            this.lblCheckOutDate.TabIndex = 35;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(615, 685);
            this.dtpCheckOutDate.Margin = new System.Windows.Forms.Padding(15);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(1880, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(259, 34);
            this.dtpCheckOutDate.TabIndex = 34;
            this.dtpCheckOutDate.Value = new System.DateTime(2021, 7, 19, 0, 0, 0, 0);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(904, 685);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(15);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(259, 34);
            this.btnCheckOut.TabIndex = 36;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 82);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Check Out";
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1227, 779);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.DGVrooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.DGVrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVrooms;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblTitle;
    }
}