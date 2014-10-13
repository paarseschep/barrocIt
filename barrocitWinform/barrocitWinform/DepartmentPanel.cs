﻿using System;
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
        protected Form loginPanel;
        public DepartmentPanel()
        {
            InitializeComponent();
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void DepartmentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPanel.Visible = true;
        }

    }
}
