using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace barrocitWinform
{
    public partial class NewProjectPanel : ListboxPanel
    {
        public NewProjectPanel(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            this.userName = userName;
            SetBackButtonType(true);
            SetCustomerList();
        }

        private void SetCustomerList()
        {
            SqlCommand command = new SqlCommand("SELECT firstname, lastname FROM tbl_Customers", SqlConnector.connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i += 2)
                    {
                        lstbCustomers.Items.Add(reader.GetValue(i).ToString() + reader.GetValue(i + 1).ToString());
                    }
                }
            }
        }
    }
}
