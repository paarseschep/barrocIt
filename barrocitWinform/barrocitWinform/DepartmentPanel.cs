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
        protected Button btnBack;
        protected Label lblClock;
        public DepartmentPanel()
        {
            InitializeComponent();
            closeMessage = "Are you sure you want to log out?";
            btnBack = new Button();
            btnBack.Text = "Back";
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
            btnBack.Location = new Point(this.Width - btnBack.Width, this.Height - btnBack.Height * 3);
            btnBack.Click += btnBack_Click;
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
            this.btnBack.Text = closeButtonText;
            this.closeMessage = closeMessage;
        }
    }
}
