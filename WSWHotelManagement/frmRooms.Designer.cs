
namespace WSWHotelManagement
{
    partial class frmRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVrooms = new System.Windows.Forms.DataGridView();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblExtraBed = new System.Windows.Forms.Label();
            this.lblDefaultPrice = new System.Windows.Forms.Label();
            this.tbDefaultPrice = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbBed = new System.Windows.Forms.ComboBox();
            this.cbExtraBed = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRoomClass = new System.Windows.Forms.Label();
            this.tbRoomClass = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVrooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVrooms.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVrooms.EnableHeadersVisualStyles = false;
            this.DGVrooms.GridColor = System.Drawing.Color.DimGray;
            this.DGVrooms.Location = new System.Drawing.Point(333, 168);
            this.DGVrooms.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DGVrooms.Name = "DGVrooms";
            this.DGVrooms.ReadOnly = true;
            this.DGVrooms.RowHeadersVisible = false;
            this.DGVrooms.ShowCellToolTips = false;
            this.DGVrooms.ShowEditingIcon = false;
            this.DGVrooms.ShowRowErrors = false;
            this.DGVrooms.Size = new System.Drawing.Size(882, 599);
            this.DGVrooms.TabIndex = 0;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(25, 201);
            this.tbRoomNumber.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(294, 34);
            this.tbRoomNumber.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 168);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(171, 29);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(20, 331);
            this.lblBed.Margin = new System.Windows.Forms.Padding(10);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(57, 29);
            this.lblBed.TabIndex = 4;
            this.lblBed.Text = "Bed";
            // 
            // lblExtraBed
            // 
            this.lblExtraBed.AutoSize = true;
            this.lblExtraBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraBed.Location = new System.Drawing.Point(20, 423);
            this.lblExtraBed.Name = "lblExtraBed";
            this.lblExtraBed.Size = new System.Drawing.Size(221, 29);
            this.lblExtraBed.TabIndex = 6;
            this.lblExtraBed.Text = "Possible Extrabeds";
            // 
            // lblDefaultPrice
            // 
            this.lblDefaultPrice.AutoSize = true;
            this.lblDefaultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultPrice.Location = new System.Drawing.Point(21, 518);
            this.lblDefaultPrice.Name = "lblDefaultPrice";
            this.lblDefaultPrice.Size = new System.Drawing.Size(142, 29);
            this.lblDefaultPrice.TabIndex = 8;
            this.lblDefaultPrice.Text = "Defaultprice";
            // 
            // tbDefaultPrice
            // 
            this.tbDefaultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefaultPrice.Location = new System.Drawing.Point(26, 551);
            this.tbDefaultPrice.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.tbDefaultPrice.Name = "tbDefaultPrice";
            this.tbDefaultPrice.Size = new System.Drawing.Size(294, 34);
            this.tbDefaultPrice.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 82);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Rooms";
            // 
            // cbBed
            // 
            this.cbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBed.FormattingEnabled = true;
            this.cbBed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbBed.Location = new System.Drawing.Point(25, 365);
            this.cbBed.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.cbBed.Name = "cbBed";
            this.cbBed.Size = new System.Drawing.Size(295, 33);
            this.cbBed.TabIndex = 10;
            // 
            // cbExtraBed
            // 
            this.cbExtraBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraBed.FormattingEnabled = true;
            this.cbExtraBed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbExtraBed.Location = new System.Drawing.Point(25, 456);
            this.cbExtraBed.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.cbExtraBed.Name = "cbExtraBed";
            this.cbExtraBed.Size = new System.Drawing.Size(295, 33);
            this.cbExtraBed.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(25, 625);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(26, 667);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(295, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(26, 709);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(295, 36);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete A Room";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRoomClass
            // 
            this.lblRoomClass.AutoSize = true;
            this.lblRoomClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomClass.Location = new System.Drawing.Point(20, 245);
            this.lblRoomClass.Name = "lblRoomClass";
            this.lblRoomClass.Size = new System.Drawing.Size(144, 29);
            this.lblRoomClass.TabIndex = 16;
            this.lblRoomClass.Text = "Room Class";
            // 
            // tbRoomClass
            // 
            this.tbRoomClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomClass.Location = new System.Drawing.Point(25, 278);
            this.tbRoomClass.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.tbRoomClass.Name = "tbRoomClass";
            this.tbRoomClass.Size = new System.Drawing.Size(294, 34);
            this.tbRoomClass.TabIndex = 15;
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1227, 779);
            this.Controls.Add(this.lblRoomClass);
            this.Controls.Add(this.tbRoomClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbExtraBed);
            this.Controls.Add(this.cbBed);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDefaultPrice);
            this.Controls.Add(this.tbDefaultPrice);
            this.Controls.Add(this.lblExtraBed);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.DGVrooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRooms";
            this.Text = "frmRooms";
            this.Load += new System.EventHandler(this.frmRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVrooms;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblExtraBed;
        private System.Windows.Forms.Label lblDefaultPrice;
        private System.Windows.Forms.TextBox tbDefaultPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbBed;
        private System.Windows.Forms.ComboBox cbExtraBed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRoomClass;
        private System.Windows.Forms.TextBox tbRoomClass;
    }
}