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
        protected Form LoginPanel;
        protected string userName;
        public DepartmentPanel()
        {
            InitializeComponent();
        }

        private void DepartmentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPanel.Visible = true;
        }

        private void clockUpdater_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
