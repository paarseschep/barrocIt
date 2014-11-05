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
        public NewProjectPanel(Form lastPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = lastPanel;
            this.userName = userName;
            UpdateGreeting();
            if (ViewPanel.checkModifications == 1)
            {
                cbCustomer.Enabled = false;
                cbCustomer.LoadCustomerList();
            }
            else
            {
                cbCustomer.Enabled = true;
                cbCustomer.LoadCustomerList();
            }
        }

        private void SaveProject(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedIndex != 0 && cbCustomer.SelectedItem != null && isInt(tbPrice.Text) && FieldValidator.CheckFilledTextBoxes(this))
            {

                List<string> dataList = AddToList(cbCustomer.GetSelectedId().ToString(), tbProjectName.Text, tbDescription.Text, tbPrice.Text);

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
