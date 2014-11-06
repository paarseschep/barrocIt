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
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Projects", 1, true);
            SqlConnector.Connect();
            viewpanel.Show();
            this.Hide();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerPanel newcustomerpanel = new NewCustomerPanel(this,0, userName);
            SqlConnector.Connect();
            //ViewPanel.checkModifications = 4;
            newcustomerpanel.Show();
            this.Hide();
        }

        private void btnMaganeCustomers_Click(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Customers", 0, true);
            //ViewPanel.checkModifications = 0;
            viewpanel.Show();
            this.Hide();
        }

        private void btAddProjects_Click(object sender, EventArgs e)
        {
            NewProjectPanel projectPanel = new NewProjectPanel(this,0, 0, userName);

            projectPanel.Show();
            this.Hide();
        }
    }
}
