using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;


//Preise vieler räume anpassen

namespace WSWHotelManagement
{
    public partial class frmCheckIn : Form
    {
        funDB fun = new funDB();
        string query;
        public frmCheckIn()
        {
          
            InitializeComponent();
        }
       

        public void setComboBox(string query, ComboBox comboBox)
        {
            SqlDataReader sqlDataReader = fun.getComboData(query);
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    comboBox.Items.Add(sqlDataReader.GetString(i));
                }
            }
            sqlDataReader.Close();
        }
        
        private void cbRoomNumber_Click(object sender, EventArgs e)
        {
            try
            {
                cbRoomNumber.Items.Clear();
                query = "select RoomNumber from rooms where Bed = " + int.Parse(cbBed.Text) + " and ExtraBeds >= " + int.Parse(cbExtraBed.Text) + "  and Available = 'Yes'";
                setComboBox(query, cbRoomNumber);
                
            }
            catch (Exception)
            {

                
            }
            
        }
int roid;
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (chbPassport.Checked)
            {
                if (tbFirstname.Text!="" && tbLastname.Text!=""&&tbCity.Text!=""&&
                    tbCountry.Text!="" && tbLanguage.Text!="" && tbMobile.Text != "" && tbPrice.Text != ""&&tbStreetNumber.Text!=""&&
                    cbBed.Text!=""&&cbExtraBed.Text!=""&&cbGender.Text!=""&&cbRoomNumber.Text!="" // evtl noch dtp hinzufügen....weiß grade nicht wie
                    )
                {
                    string firstname = tbFirstname.Text;
                    string lastname = tbLastname.Text;
                    string city = tbCity.Text;
                    string country = tbCountry.Text;
                    string language = tbLanguage.Text;
                    string mobilen = tbMobile.Text;                   
                    string mStreetNum = tbStreetNumber.Text;
                    string gender = cbGender.Text;
                    string dob = dtpDateOfBirth.Value.ToString();
                    string checkInDate = dtpCheckInDate.Value.ToString();

                      query = "insert into customer (Firstname,Lastname,Mobilenumber,Gender,sLanguage,DateOfBirth,Country,City,StreetNumber,CheckInDate,roomid,CheckOutDate) values ('" + firstname + "','" + lastname + "','" + mobilen + "','" + gender + "','" + language + "','" + dob  + "','" + country + "','" + city + "','" + mStreetNum + "','" + checkInDate + "','" + roid + "','-') update rooms set Available = 'No' where RoomNumber = '" + cbRoomNumber.Text+"'";

                    fun.setData(query, "Room " + cbRoomNumber.Text + " is booked now");
                }
                else
                {
                    MessageBox.Show("Fill all fields");
                }
            }
            else
            {
                MessageBox.Show("Please check customers passport");
            }
        }
          
        private void cbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select Price,RoomID from rooms where RoomNumber = '"+cbRoomNumber.Text+"' ";
            DataSet dataSet = fun.getData(query);
            tbPrice.Text = dataSet.Tables[0].Rows[0][0].ToString();
            roid = int.Parse(dataSet.Tables[0].Rows[0][1].ToString());

        }

        private void clear()
        {
            tbFirstname.Clear();
            tbLastname.Clear();
            tbCity.Clear();
            tbCountry.Clear();
            tbLanguage.Clear();
            tbMobile.Clear();
            tbPrice.Clear();
            tbStreetNumber.Clear();
            cbGender.SelectedIndex = -1;
            cbBed.SelectedIndex = -1;
            cbExtraBed.SelectedIndex = -1;
            cbRoomNumber.SelectedIndex = -1;

        }
    }
}
