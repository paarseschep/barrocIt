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
        public ChangeVisibilityPanel(int customerId, string table)
        {
            InitializeComponent();
            this.table = table;
            this.customerId = customerId;
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
            newDataList.Add(Convert.ToInt32(rbSetVisible.Enabled).ToString());
            string columsInRightOrder = " firstname, lastname, email, phonenumber, homenumber, postalCode1, city1, province, email_company, phonenumber_company, companyName, insurance_id, faxnumber";
            SqlConnector.modifyDatabase(newDataList,customerId, columsInRightOrder, table);
        }
    }
}
