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
        private CustomerBox customerBox;
        public NewProjectPanel(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            customerBox = new CustomerBox();
            SetBackButtonType(true);
            this.Controls.Add(customerBox);
        }

        private void SaveProject(object sender, EventArgs e)
        {
            if (customerBox.SelectedIndex != 0 && customerBox.SelectedItem != null && isInt(tbPrice.Text) && CheckFilledTextBoxes())
            {

                List<string> dataList = AddToList(customerBox.GetSelectedId().ToString(), tbProjectName.Text, tbDescription.Text, tbPrice.Text);

                string colums = " Customer_id, name, description, price";

                if (cbDeadLine.Checked)
                {
                    dataList.Add(datePicker.Text);
                    colums += ", deadline";
                }

                if (SqlConnector.InsertDataIntoDatabase(dataList, colums, "Tbl_Projects"))
                {
                    MessageBox.Show("The project has been succesfully submitted to the server.",
                                    "Successfully saved the project.");
                    SqlConnector.Connect();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to save project. Are you sure all fields are filled in correctly and are you sure you selected a customer?",
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

        private List<string> AddToList(params string[] dataList)
        {
            return dataList.ToList();
        }

        private bool isInt(string input)
        {
            int x;
            return int.TryParse(input, out x);
        }

        private void cbDeadLine_CheckedChanged(object sender, EventArgs e)
        {
            datePicker.Enabled = !datePicker.Enabled;
        }
    }
}
