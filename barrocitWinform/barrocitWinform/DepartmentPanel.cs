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
        protected string userName;
        protected Form lastPanel;
        protected BackButton btnBack;
        protected Label lblClock;
        public DepartmentPanel()
        {
            InitializeComponent();
            btnBack = new BackButton(this);
            SetBackButtonType(false);
            lblClock = new Label();
            lblClock.Location = new Point(this.Width - btnBack.Width, btnBack.Height / 2);
            lblClock.Anchor = AnchorStyles.None;
            lblClock.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            lblClock.AutoSize = true;
            this.Controls.Add(btnBack);
            this.Controls.Add(lblClock);
        }

        protected void UpdateGreeting()
        {
            lblGreeting.Text += userName + "!";
        }

        private void clockUpdater_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(btnBack.closeMessage, "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            SqlConnector.connection.Close();
        }

        private void DepartmentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            lastPanel.Visible = true;
        }
        public void SetBackButtonType(bool isLogoutButton)
        {
            switch (isLogoutButton)
            {
                case true:
                    btnBack.SetText("Logout", "Are you sure you want to logout?");
                    this.FormClosed += Logout;
                    break;
                case false:
                    btnBack.SetText("Back", "Are you sure you want to go close this window?");
                    this.FormClosed -= Logout;
                    break;
            }
        }

    }
}
