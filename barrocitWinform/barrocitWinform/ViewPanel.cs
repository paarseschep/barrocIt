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
    public partial class ViewPanel : DepartmentPanel
    {
        Form financePanel;
        public ViewPanel(Form financePanel, string userName, object data)
        {
            InitializeComponent();
            this.financePanel = financePanel;
            this.userName = userName;
            UpdateGreeting();
            dataTables.DataSource = data;
            dataTables.ReadOnly = true;
        }
    }
}
