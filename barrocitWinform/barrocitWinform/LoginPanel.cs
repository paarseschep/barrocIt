using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    public partial class LoginPanel : Form
    {
        SqlConnection connection;

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            //Login check stuff here
            connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Drace\Documents\GitHub\barrocIt\barrocitWinform\barrocitWinform\Database.mdf;Integrated Security=True;Connect Timeout=30");
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                
                int departmentNumber = 0;
                string userName = "TestUserName";
                OpenUserPanel(departmentNumber, userName);
            }
            else
            {

            }
        }



        private void OpenUserPanel(int departmentNumber, string userName)
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this form?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
