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
        public NewInvoicePanel(Form loginPanel, string userName, bool isEdit)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            this.isEdit = isEdit;
            cbPaid.Enabled = false;
            UpdateGreeting();
            customerBox1.LoadCustomerList("SELECT * FROM Tbl_Customers", 2);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
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
                }
                else if(isEdit)
                {
                    int currentCustomerId = customerBox1.GetSelectedId();
                    customerBox1.GetSelectedId();
                    int selectedInvoiceId =((ViewPanel)lastPanel).GetSelectedId(0);
                    List<string> AllNewUserData = AddToList(selectedInvoiceId.ToString(), currentCustomerId.ToString(), tbFactuurbedrag.Text, datePicker.Text, tbGrootboekrekeningnummer.Text, tbBtwCode.Text);
                    string columns = " Customer_Id, factuurBedrag, invoiceDate, grootboekrekeningnummer, BTWCode";
                    SqlConnector.modifyDatabase(AllNewUserData,currentCustomerId, columns, "Tbl_Invoices","invoice");
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
