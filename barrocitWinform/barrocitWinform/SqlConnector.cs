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
        /// <summary>
        /// Gets the department ID and trows an exception when failed.
        /// </summary>
        /// <param name="userName">Username from department</param>
        /// <param name="password">Password for the department</param>
        /// <returns></returns>
        static public int Login(string userName, string password)
        {
            int department = -1;

            try
            {
                if (connection.ConnectionString == "")
                {
                    connection.ConnectionString = connectionString;
                }

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

        /// <summary>
        /// Inserts data into database.
        /// </summary>
        /// <param name="data">List with data you would like to add (same order as colums).</param>
        /// <param name="colums">The colums you would like to insert data in.</param>
        /// <param name="table">The table you would like to insert data in.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns "true" if the modification worked if it failed because a reason it will return "false".
        /// </summary>
        /// <param name="data">A list needed what data you would like in the colums (same order as colums).</param>
        /// <param name="customerId">Current customer ID</param>
        /// <param name="colums">The colums in the right order as they are in the Table.</param>
        /// <param name="table">The table you would like to modify</param>
        /// <param name="invoiceOrProject">Give invoice if you would like to modify a invoice give project if you want to modify something else.</param>
        /// <returns></returns>
        static public bool modifyDatabase(List<string> data, int customerId, string colums, string table, string invoiceOrProject)
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
                string tableStringExtractedFinal = tableStringExtracted.Remove(tableStringExtracted.Length - 1);
                string sqlcommand = "";

                if (invoiceOrProject == "project")
                {
                    sqlcommand = "UPDATE [" + table + "] SET " + tableStringExtractedFinal + " WHERE Customer_id=" + customerId;
                }
                else if (invoiceOrProject == "invoice")
                {
                    string projectId = data[0];
                    data.RemoveAt(0);
                    sqlcommand = "UPDATE [" + table + "] SET " + tableStringExtractedFinal + " WHERE Customer_id=" + customerId + " AND Project_id=" + projectId;
                }

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
