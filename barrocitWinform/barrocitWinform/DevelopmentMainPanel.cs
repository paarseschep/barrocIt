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
    public partial class DevelopmentMainPanel : DepartmentPanel
    {
        public DevelopmentMainPanel(Form loginPanel, string userName, bool logoutWhenClose)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
            SetBackButtonType(logoutWhenClose);
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            ViewPanel viewpanel = new ViewPanel(this, userName, "Tbl_Customers", true);
            TextBox myText = new TextBox();
            Button myBut = new Button();
            myBut.Size = new Size(100, 20);
            myBut.Location = new Point(120, 2);
            myBut.Text = "Go!";
            myText.Location = new Point(12, 2);
            viewpanel.Controls.Add(myText);
            viewpanel.Controls.Add(myBut);
            viewpanel.Show();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
