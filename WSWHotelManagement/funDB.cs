using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WSWHotelManagement
{
    class funDB
    {
        protected SqlConnection getConnection()
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "data source=DESKTOP-3FBPK6K\\MARCOSQL;database=WSWHotelManagement;integrated security = True";
            return sqlcon;
        }

        public DataSet getData(string query)
        {
            SqlConnection sqlConnection = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = query;
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            DataSet dSet = new DataSet();
            dAdapter.Fill(dSet);

            return dSet;
        }

        public void setData(String query, String message)
        {
            SqlConnection sqlcon = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            sqlcon.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show(message);
        }

        public SqlDataReader getComboData(string query) {

            SqlConnection sqlConnection = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            
            return sqlDataReader;
        }
    }
}
