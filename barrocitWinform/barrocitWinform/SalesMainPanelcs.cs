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
    public partial class SalesMainPanelcs : DepartmentPanel
    {
        ViewPanel viewpanel;
        public SalesMainPanelcs(Form loginPanel, string userName, bool logoutWhenClose)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            SetBackButtonType(logoutWhenClose);
        }

        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            viewpanel = new ViewPanel(this, userName, "Tbl_Projects", true);
            SqlConnector.Connect();
            ViewPanel.checkModifications = 1;
            viewpanel.Show();
            this.Hide();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerPanel newcustomerpanel = new NewCustomerPanel(this, userName);
            SqlConnector.Connect();
            ViewPanel.checkModifications = 4;
            newcustomerpanel.Show();
            this.Hide();
        }

        private void btnMaganeCustomers_Click(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            viewpanel = new ViewPanel(this, userName, "Tbl_Customers", true);
            ViewPanel.checkModifications = 0;
            viewpanel.Show();
            this.Hide();
        }

        private void btAddProjects_Click(object sender, EventArgs e)
        {
            ViewPanel.checkModifications = 0;
            NewProjectPanel projectPanel = new NewProjectPanel(this, userName);

            projectPanel.Show();
            this.Hide();
        }
    }
}
