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
    public partial class FinanceMainPanel : DepartmentPanel
    {
        public bool isEdit;
        public FinanceMainPanel(Form loginPanel, string userName, bool logoutWhenClose)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            SetBackButtonType(logoutWhenClose);
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Invoices", 6);
            viewpanel.Show();
            this.Hide();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            isEdit = false;
            NewInvoicePanel newinvoicepanel = new NewInvoicePanel(this, userName, isEdit);
            SqlConnector.Connect();
            newinvoicepanel.Show();
            this.Hide();
        }

        private void btEditInvoice_Click(object sender, EventArgs e)
        {
            isEdit = true;
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Invoices", 5);
            viewpanel.Show();
            this.Hide();
        }
    }
}
