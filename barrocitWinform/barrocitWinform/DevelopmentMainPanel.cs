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
    public partial class DevelopmentMainPanel : DepartmentPanel
    {
        public DevelopmentMainPanel(Form loginPanel, string userName, bool logoutWhenClose)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            SetBackButtonType(logoutWhenClose);
        }

        private void btnViewProject_Click(object sender, EventArgs e)
        {
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Projects", 5);
            viewpanel.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Projects", 4);
            viewpanel.Show();
            this.Hide();
        }
    }
}
