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
    public partial class NewInvoicePanel : DepartmentPanel
    {
        public NewInvoicePanel(Form loginPanel, string userName)
        {
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
        }
    }
}
