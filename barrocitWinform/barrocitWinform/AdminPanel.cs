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
        public AdminPanel(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            this.userName = userName;
            SetBackButtonType(true);
            
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
            switch (departmentNumber)
            {
                case 1:
                    DevelopmentMainPanel developmentPanel = new DevelopmentMainPanel(this, userName, false);
                    developmentPanel.Show();
                    this.Hide();
                    break;
                case 2:
                    FinanceMainPanel financePanel = new FinanceMainPanel(this, userName, false);
                    financePanel.Show();
                    this.Hide();
                    break;
                case 3:
                    SalesMainPanelcs salesPanel = new SalesMainPanelcs(this, userName, false);
                    salesPanel.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
