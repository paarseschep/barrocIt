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
    public partial class FinanceMainPanel : DepartmentPanel
    {
        public FinanceMainPanel(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            UpdateGreeting(userName);
        }
        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Invoices", true);
            TextBox myText = new TextBox();
            Button myBut = new Button();
            myBut.Size = new Size(100, 20);
            myBut.Location = new Point(120,2);
            myBut.Text = "Go!";
            myText.Location = new Point(12,2);
            viewpanel.Controls.Add(myText);
            viewpanel.Controls.Add(myBut);
            viewpanel.Show();
        }
    }
}
