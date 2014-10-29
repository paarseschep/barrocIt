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
        public SalesMainPanelcs(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            UpdateGreeting(userName);
        }

        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            ViewPanel manageProject = new ViewPanel(this, userName, "Tbl_Projects", false);
            manageProject.Show();
        }
    }
}
