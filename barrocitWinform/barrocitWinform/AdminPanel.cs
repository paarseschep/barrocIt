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
    public partial class AdminPanel : DepartmentPanel
    {
        public AdminPanel(Form LoginPanel, string userName)
        {
            InitializeComponent();
            this.LoginPanel = LoginPanel;
            this.userName = userName;
            lblGreeting.Text += userName + "!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
