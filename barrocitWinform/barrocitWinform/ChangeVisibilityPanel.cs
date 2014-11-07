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
        string boolToEdit;
        public ChangeVisibilityPanel(Form lastPanel, int customerId, string dataName, bool value, string table, string boolToEdit)
        {
            InitializeComponent();
            this.table = table;
            this.customerId = customerId;
            lbData.Text = dataName;
            this.lastPanel = lastPanel;
            this.boolToEdit = boolToEdit;
            SetSelectedData(dataName, value);
        }

        public void SetSelectedData(string dataName, bool enabled)
        {
            lbData.Text = dataName;

            if (enabled)
            {
                rbSetVisible.Checked = true;
            }
            else
            {
                rbSetInvisible.Checked = true;
            }
        }
        public void SetText (string radioButton1Text, string radioButton2Text)
        {
            rbSetVisible.Text = radioButton1Text;
            rbSetInvisible.Text = radioButton2Text;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            List<string> newDataList = new List<string>();
            newDataList.Add(Convert.ToInt32(rbSetVisible.Checked).ToString());
            if (SqlConnector.modifyDatabase(newDataList, customerId, boolToEdit, table, "project"))
            {
                MessageBox.Show("The value has been successfully changed.", "Yay");
                this.Close();
            }
            
        }
    }
}
