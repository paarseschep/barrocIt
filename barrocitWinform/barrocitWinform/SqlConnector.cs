using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace barrocitWinform
{
    static class SqlConnector
    {
        public static SqlConnection connection;
        public static string connectionString;
        static public bool Connect()
        {
            bool gotConnected = false;
            connection = new SqlConnection(connectionString);
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
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to connect to server.");
            }
            return department;
        }
        static public bool InsertDataIntoDatabase(List<string> data, string colums, string table)
        {
            bool success = false;
            try
            {
                List<string> extracteTable = new List<string>();

                foreach (string cur in colums.Split(','))
                {
                    string temp = cur.Replace(' ', '@');
                    extracteTable.Add(new StringBuilder(temp).Append(",").ToString());
                }

                string[] tableArray = extracteTable.ToArray();
                string tableStringExtracted = "";
                foreach (string oneTable in tableArray)
                {
                    tableStringExtracted += oneTable;
                }

                string sqlcommand = "INSERT INTO " + table + " (" + colums + ") VALUES (" + tableStringExtracted;
                int lastChar = sqlcommand.Length;
                string finalSqlCommand = sqlcommand.Remove(lastChar - 1) + ")";

                using (connection)
                {
                    SqlCommand cmd = new SqlCommand(finalSqlCommand);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = connection;
                    int i = 0;
                    foreach (string item in extracteTable)
                    {
                        string temp = item.Remove(item.Length - 1);
                        cmd.Parameters.AddWithValue(temp, data[i]);

                        i++;
                    }
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to save data to the server.");
            }
            return success;
        }
        static public bool modifyDatabase(List<string> data, int customerId, string colums, string table)
        {
            bool success = false;
            try
            {
                List<string> extracteTable = new List<string>();

                foreach (string cur in colums.Split(','))
                {
                    string temp = cur.Replace(' ', '@');
                    extracteTable.Add(new StringBuilder(temp).Append(",").ToString());
                }

                string[] tableArray = extracteTable.ToArray();
                string tableStringExtracted = "";

                foreach (string oneTable in tableArray)
                {
                    tableStringExtracted += "[" + oneTable.Remove(0, 1).Replace(",", "") + "]" + "=" + oneTable + "";
                }
                string tableStringExtractedFinal = tableStringExtracted.Remove(tableStringExtracted.Length-1);
                string sqlcommand = "UPDATE [" + table + "] SET " + tableStringExtractedFinal + " WHERE Customer_id=" + customerId;
                int lastChar = sqlcommand.Length;
                using (connection)
                {
                    SqlCommand cmd = new SqlCommand(sqlcommand);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = connection;
                    int i = 0;
                    foreach (string item in extracteTable)
                    {
                        string temp = item.Remove(item.Length - 1);
                        temp = temp.Remove(0, 1);
                        cmd.Parameters.AddWithValue(temp, data[i]);

                        i++;
                    }
                    cmd.ExecuteNonQuery();
                }
                success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed to save data to the server.");
            }
            return success;
        }
    }
}
