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
            this.UpdateGreeting(userName);
        }
    }
}
