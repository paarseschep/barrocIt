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

        static public int Login(string userName, string password)
        {
            int department;
            try
            {
                SqlDataReader dataReader;
                SqlCommand loginCommand = new SqlCommand(
                    "SELECT * FROM Tbl_Users" +
                    "WHERE Username = " + userName +
                    " AND Password = " + password,
                    connection);

                dataReader = loginCommand.ExecuteReader();
                department = (int)dataReader["department_id"];
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Failed to connect to server.");
                department = -1;
            }
            return department;
        }
    }
}
