using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            SqlConnector.connection = new SqlConnection (   @"Data Source=(LocalDB)\v11.0;
                                                            AttachDbFilename="+ Directory.GetCurrentDirectory() + @"\Database.mdf;
                                                            Integrated Security=True;
                                                            Connect Timeout=30");
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            switch (SqlConnector.Connect())
            {
                case true:
                    {
                        switch (SqlConnector.Login(tbUsername.Text, tbPassword.Text))
                        {
                            case 0:
                                AdminPanel adminPanel = new AdminPanel(this, tbUsername.Text);
                                adminPanel.Show();
                                this.Hide();
                                break;
                            case 1:
                                //development form
                                break;
                            case 2:
                                FinanceMainPanel financePanel = new FinanceMainPanel(this, tbUsername.Text);
                                financePanel.Show();
                                this.Hide();
                                break;
                            case 3:
                                SalesMainPanelcs salesPanel = new SalesMainPanelcs(this, tbUsername.Text);
                                salesPanel.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Failed to log in. Are you sure all fields are filled in correctly?", 
                                                "Error logging in.");
                                break;
                        }
                        break;
                    }
            }
            SqlConnector.connection.Close();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this window?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
