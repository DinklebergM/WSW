
namespace Hotel_Management_
{
    partial class frmAllRooms
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.listBR = new System.Windows.Forms.ListView();
            this.cHid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHMaxPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHRoomClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSpEquipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBR
            // 
            this.listBR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHid,
            this.cHRoomNumber,
            this.cHFloor,
            this.cHMaxPerson,
            this.cHSize,
            this.cHRoomClass,
            this.cHView,
            this.cHSpEquipment});
            this.listBR.HideSelection = false;
            this.listBR.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.listBR.Location = new System.Drawing.Point(228, 12);
            this.listBR.Name = "listBR";
            this.listBR.Size = new System.Drawing.Size(654, 373);
            this.listBR.TabIndex = 0;
            this.listBR.UseCompatibleStateImageBehavior = false;
            this.listBR.View = System.Windows.Forms.View.Details;
            // 
            // cHid
            // 
            this.cHid.Text = "id";
            this.cHid.Width = 40;
            // 
            // cHRoomNumber
            // 
            this.cHRoomNumber.Text = "Room Number";
            this.cHRoomNumber.Width = 80;
            // 
            // cHFloor
            // 
            this.cHFloor.Text = "Floor";
            this.cHFloor.Width = 80;
            // 
            // cHMaxPerson
            // 
            this.cHMaxPerson.Text = "Max Person";
            this.cHMaxPerson.Width = 80;
            // 
            // cHSize
            // 
            this.cHSize.Text = "Size(qm)";
            this.cHSize.Width = 80;
            // 
            // cHRoomClass
            // 
            this.cHRoomClass.Text = "Room Class";
            this.cHRoomClass.Width = 80;
            // 
            // cHView
            // 
            this.cHView.Text = "View";
            this.cHView.Width = 80;
            // 
            // cHSpEquipment
            // 
            this.cHSpEquipment.Text = "Special Equipment";
            this.cHSpEquipment.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAllRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(894, 589);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllRooms";
            this.Text = "frmAllRooms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listBR;
        private System.Windows.Forms.ColumnHeader cHid;
        private System.Windows.Forms.ColumnHeader cHRoomNumber;
        private System.Windows.Forms.ColumnHeader cHFloor;
        private System.Windows.Forms.ColumnHeader cHMaxPerson;
        private System.Windows.Forms.ColumnHeader cHSize;
        private System.Windows.Forms.ColumnHeader cHRoomClass;
        private System.Windows.Forms.ColumnHeader cHView;
        private System.Windows.Forms.ColumnHeader cHSpEquipment;
        private System.Windows.Forms.Button btnAdd;
    }
}