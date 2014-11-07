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
    public partial class ChangeVisibilityPanel : DepartmentPanel
    {
        string table;
        int customerId;
        public ChangeVisibilityPanel(Form lastPanel, int customerId, string dataName, string table)
        {
            InitializeComponent();
            this.table = table;
            this.customerId = customerId;
            lbData.Text = dataName;
            this.lastPanel = lastPanel;
        }

        public void SetSelectedData(string data, bool enabled)
        {
            lbData.Text = data;

            if (enabled)
            {
                rbSetVisible.Checked = true;
            }
            else
            {
                rbSetInvisible.Checked = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            List<string> newDataList = new List<string>();
            newDataList.Add(Convert.ToInt32(rbSetVisible.Checked).ToString());
            string columsInRightOrder = " isVisible";
            SqlConnector.modifyDatabase(newDataList, customerId, columsInRightOrder, table);
        }
    }
}
