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
            SqlConnector.Connect();
            this.Items.Add("ID" + " \t" + "First name" + "\t" + "Last Name");
            SqlCommand command;
            ViewPanel form = new ViewPanel();
            if (ViewPanel.checkModifications == 1)
            {
                int currentCustomerId = form.CurrentCustomerId();
                command = new SqlCommand("SELECT Customer_Id, firstname, lastname FROM tbl_Customers WHERE Customer_Id=" + currentCustomerId, SqlConnector.connection);
            }
            else
            {
                 command = new SqlCommand("SELECT Customer_Id, firstname, lastname FROM tbl_Customers", SqlConnector.connection);
            }
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i += 3)
                    {
                        this.Items.Add(reader.GetValue(i) + " \t" + reader.GetValue(i + 1) + "\t\t" + reader.GetValue(i + 2));
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
