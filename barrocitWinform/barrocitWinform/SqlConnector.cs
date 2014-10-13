using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace barrocitWinform
{
    static class SqlConnector
    {
        public static SqlConnection connection;
        static public bool Connect()
        {
            bool gotConnected = false;
            try
            {
                SqlConnector.connection.Open();
                gotConnected = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to connect to server.");
            }
            return gotConnected;
        }

        static public int Login(string userName, string password)
        {
            int department = -1;
            try
            {
                SqlDataReader dataReader;
                SqlCommand loginCommand = new SqlCommand(
                    @"SELECT * FROM Tbl_Users " +
                    @"WHERE username= '" + userName +
                    @"'AND password= '" + password + "'",
                    connection);

                dataReader = loginCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    department = (int)dataReader["department_id"];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to connect to server.");
            }
            return department;
        }
    }
}
