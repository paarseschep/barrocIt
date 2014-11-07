using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    public partial class NewInvoicePanel : DepartmentPanel
    {
        bool isEdit;
        /// <param name="lastPanel">"This"</param>
        /// <param name="userName">The globally used login username.</param>
        /// <param name="isEdit">Able to edit true or false</param>
        /// <param name="addOrModify">"add" to add and "modify" to modify invoice</param>
        public NewInvoicePanel(Form lastPanel, string userName, bool isEdit, string addOrModify)
        {
            InitializeComponent();
            this.lastPanel = lastPanel;
            this.userName = userName;
            this.isEdit = isEdit;
            cbPaid.Enabled = false;
            UpdateGreeting();
            if (addOrModify == "add")
            {
                customerBox1.LoadCustomerList("SELECT * FROM Tbl_Customers", 2);
            }
            else if(addOrModify == "modify")
            {
                int customerId = ((ViewPanel)lastPanel).GetSelectedId(1);
                customerBox1.LoadCustomerList("SELECT * FROM Tbl_Customers WHERE Customer_Id= " + customerId.ToString(), 2);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            if (customerBox1.SelectedItem != null && FieldValidator.CheckFilledTextBoxes(this))
            {
                SqlConnector.Connect();
                if (!isEdit)
                {
                    int currentCustomerId = customerBox1.GetSelectedId();
                    customerBox1.GetSelectedId();
                    List<string> AllNewUserData = AddToList(currentCustomerId.ToString(), tbFactuurbedrag.Text, datePicker.Text, tbGrootboekrekeningnummer.Text, tbBtwCode.Text);
                    string columns = " Customer_Id, factuurBedrag, invoiceDate, grootboekrekeningnummer, BTWCode";
                    SqlConnector.InsertDataIntoDatabase(AllNewUserData, columns, "Tbl_Invoices");
                    MessageBox.Show("You have succesfully added a new invoice this form will close now.");
                    this.Close();
                }
                else if(isEdit)
                {
                    int currentCustomerId = customerBox1.GetSelectedId();
                    customerBox1.GetSelectedId();
                    int selectedInvoiceId =((ViewPanel)lastPanel).GetSelectedId(0);
                    List<string> AllNewUserData = AddToList(selectedInvoiceId.ToString(), currentCustomerId.ToString(), tbFactuurbedrag.Text, datePicker.Text, tbGrootboekrekeningnummer.Text, tbBtwCode.Text);
                    string columns = " Customer_Id, factuurBedrag, invoiceDate, grootboekrekeningnummer, BTWCode";
                    SqlConnector.modifyDatabase(AllNewUserData,currentCustomerId, columns, "Tbl_Invoices","invoice");
                    MessageBox.Show("You have succesfully edited a new invoice this form will close now.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer and fill in all the boxes.");
            }
        }

        public List<string> AddToList(params string[] dataList)
        {
            return dataList.ToList();
        }
    }
}
