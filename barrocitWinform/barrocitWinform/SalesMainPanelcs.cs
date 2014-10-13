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
    public partial class SalesMainPanelcs : DepartmentPanel
    {
        public SalesMainPanelcs(Form LoginPanel, string userName)
        {
            InitializeComponent();
            this.LoginPanel = LoginPanel;
            this.userName = userName;
        }
    }
}
