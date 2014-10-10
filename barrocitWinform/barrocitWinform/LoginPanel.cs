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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            //Login check stuff here
            int departmentNumber = 0;
            string userName = "TestUserName";
            Login(departmentNumber, userName);
        }

        private void Login(int departmentNumber, string userName)
        {
            switch(departmentNumber)
            {
                case 0:
                    AdminPanel adminPanel = new AdminPanel(this, userName);
                    adminPanel.Visible = true;
                    break;
            }
            this.Visible = false;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
