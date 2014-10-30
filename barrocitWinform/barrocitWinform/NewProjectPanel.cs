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
    public partial class NewProjectPanel : DepartmentPanel
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
            lstbCustomers.Items.Add("ID" + " \t" + "First name" + "\t" + "Last Name");
            SqlCommand command = new SqlCommand("SELECT Customer_Id, firstname, lastname FROM tbl_Customers", SqlConnector.connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i += 3)
                    {
                        lstbCustomers.Items.Add(reader.GetValue(i) + " \t" + reader.GetValue(i + 1) + "\t\t" + reader.GetValue(i + 2));
                    }
                }
            }
        }

        private void SaveProject(object sender, EventArgs e)
        {
            if (lstbCustomers.SelectedItem != null && CheckFilledTextBoxes())
            {
                int findId = lstbCustomers.SelectedItem.ToString().IndexOf(" ");
                string idString = "";

                for (int i = 0; i < findId; i++)
                {
                    idString += lstbCustomers.SelectedItem.ToString()[i];
                }

                int customerId = Convert.ToInt32(idString);


                List<string> dataList = AddToList(customerId.ToString(), tbProjectName.Text, tbDescription.Text, tbPrice.Text, datePicker.Text);

                //SqlConnector.InsertDataIntoDatabase(dataList, " Customer_id, name, description, price, deadline", "Tbl_Projects");

            }
            else
            {
                MessageBox.Show("Unable to save project. Are you sure all fields are filled in and are you sure you selected a customer?",
                                "Error saving Project");
            }
        }

        private bool CheckFilledTextBoxes()
        {
            bool isTbFilled = false;
            foreach (object obj in this.Controls)
            {
                if (obj is TextBox)
                {
                    if (((TextBox)obj).Text != "")
                    {
                        isTbFilled = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return isTbFilled;
        }
        public List<string> AddToList(params string[] dataList)
        {
            return dataList.ToList();
        }
    }
}
