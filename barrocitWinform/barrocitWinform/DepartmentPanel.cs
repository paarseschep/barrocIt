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
    public partial class DepartmentPanel : Form
    {
        public string closeMessage;
        protected string userName;
        protected Form lastPanel;
        public DepartmentPanel()
        {
            InitializeComponent();
            closeMessage = "Are you sure you want to log out?";
        }

        protected void UpdateGreeting(string userName)
        {
            lblGreeting.Text += userName + "!";
        }

        private void clockUpdater_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(closeMessage, "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void DepartmentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            lastPanel.Visible = true;
        }
        public void SetCloseMessage(string closeButtonText, string closeMessage)
        {
            this.btnLogout.Text = closeButtonText;
            this.closeMessage = closeMessage;
        }
    }
}
