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
    public partial class AdminPanel : DepartmentPanel
    {
        public AdminPanel(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            this.userName = userName;
            btnBack.Text = "Logout";
        }

        private void btnDevelopment_Click(object sender, EventArgs e)
        {
            OpenUserPanel(1);
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            OpenUserPanel(2);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenUserPanel(3);
        }

        private void OpenUserPanel (int departmentNumber)
        {
            string closeMessage = "Are you sure you want to go back?";
            switch (departmentNumber)
            {
                case 1:
                    //development form
                    break;
                case 2:
                    FinanceMainPanel financePanel = new FinanceMainPanel(this, userName);
                    financePanel.Show();
                    financePanel.SetCloseMessage("Back", closeMessage);
                    this.Hide();
                    break;
                case 3:
                    SalesMainPanelcs salesPanel = new SalesMainPanelcs(this, userName);
                    salesPanel.Show();
                    salesPanel.SetCloseMessage("Back", closeMessage);
                    this.Hide();
                    break;
            }
        }
    }
}
