using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    class CustomerBox : ListBox
    {
        public void LoadCustomerList()
        {
            this.Items.Add("ID" + " \t" + "First name" + "\t" + "Last Name");
            SqlCommand command = new SqlCommand("SELECT isVisible, Customer_Id, firstname, lastname FROM tbl_Customers", SqlConnector.connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (var i = 0; i < reader.FieldCount; i += 4)
                    {
                        if ((bool)reader.GetValue(i))
                        {
                            this.Items.Add(reader.GetValue(i + 1) + " \t" + reader.GetValue(i + 2) + "\t\t" + reader.GetValue(i + 3));
                        }
                    }
                }
            }
        }

        public int GetSelectedId()
        {
            int findId = this.SelectedItem.ToString().IndexOf(" ");
            string idString = "";

            for (int i = 0; i < findId; i++)
            {
                idString += this.SelectedItem.ToString()[i];
            }

            return Convert.ToInt32(idString);
        }
    }
}
