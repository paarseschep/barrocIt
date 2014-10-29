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
            ViewPanel manageProject = new ViewPanel(this, userName, "Tbl_Projects", false);
            manageProject.Show();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerPanel newcustomerpanel = new NewCustomerPanel(this, userName);
            newcustomerpanel.Show();
        }
    }
}
