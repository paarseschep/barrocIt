using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace barrocitWinform
{
    public partial class ViewPanel : DepartmentPanel
    {
        string table;
        int checkModifications;
        //public static int currentCustomerId;
        /// <param name="lastPanel"> Always "This."</param>
        /// <param name="userName"> Username.</param>
        /// <param name="table">The string of the table you want to acces.</param>
        /// <param name="isReadOnly">True to not edit, false to edit.</param> 

        public ViewPanel(Form lastPanel, string userName, string table, int checkModifications)
        {
            InitializeComponent();
            SqlConnector.Connect();
            this.userName = userName;
            this.checkModifications = checkModifications;
            UpdateGreeting();
            this.table = table;
            this.lastPanel = lastPanel;
            if (checkModifications == 6)
            {
                dataTables.Enabled = false;
            }
            RefreshDataGrid();
        }

        private void dataTables_DoubleClick(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            if (checkModifications == 4)
            {
                int selectedRow = dataTables.CurrentRow.Index;

                int currenCustomerId = GetSelectedId(0);
                NewCustomerPanel newCustomerPanel = new NewCustomerPanel(this, 4, userName);
                newCustomerPanel.tbFirstname.Text = dataTables.Rows[selectedRow].Cells[1].Value.ToString();
                newCustomerPanel.tbLastname.Text = dataTables.Rows[selectedRow].Cells[2].Value.ToString();
                newCustomerPanel.tbCompany.Text = dataTables.Rows[selectedRow].Cells[3].Value.ToString();
                newCustomerPanel.tbCompanyEmail.Text = dataTables.Rows[selectedRow].Cells[4].Value.ToString();
                newCustomerPanel.tbCompanyPhone.Text = dataTables.Rows[selectedRow].Cells[5].Value.ToString();
                newCustomerPanel.tbEmail.Text = dataTables.Rows[selectedRow].Cells[6].Value.ToString();
                newCustomerPanel.tbPostalcode.Text = dataTables.Rows[selectedRow].Cells[7].Value.ToString();
                newCustomerPanel.tbCity.Text = dataTables.Rows[selectedRow].Cells[8].Value.ToString();
                newCustomerPanel.tbStreetnumber.Text = dataTables.Rows[selectedRow].Cells[9].Value.ToString();
                newCustomerPanel.tbProvince.Text = dataTables.Rows[selectedRow].Cells[10].Value.ToString();
                newCustomerPanel.tbPhone.Text = dataTables.Rows[selectedRow].Cells[11].Value.ToString();
                newCustomerPanel.tbFaxnumber.Text = dataTables.Rows[selectedRow].Cells[12].Value.ToString();
                newCustomerPanel.tbInsurance.Text = dataTables.Rows[selectedRow].Cells[13].Value.ToString();
                newCustomerPanel.Show();
                this.Hide();
            }
            else if (checkModifications == 1)
            {
                int selectedRow = dataTables.CurrentRow.Index;

                NewProjectPanel newProjectPanel = new NewProjectPanel(this, GetSelectedId(0), checkModifications, userName);
                newProjectPanel.tbProjectName.Text = dataTables.Rows[selectedRow].Cells[2].Value.ToString();
                newProjectPanel.tbDescription.Text = dataTables.Rows[selectedRow].Cells[3].Value.ToString();
                newProjectPanel.datePicker.Text = dataTables.Rows[selectedRow].Cells[6].Value.ToString();
                newProjectPanel.tbPrice.Text = dataTables.Rows[selectedRow].Cells[7].Value.ToString();
                newProjectPanel.Show();
                this.Hide();
            }
            else if (checkModifications == 3)
            {
                OpenChangeVisibility(dataTables.Rows[dataTables.CurrentRow.Index], dataTables.Rows[0].Cells.Count, " isVisible");
            }
            else if (checkModifications == 0)
            {
                OpenChangeVisibility(dataTables.Rows[dataTables.CurrentRow.Index], dataTables.Rows[0].Cells.Count - 1, " completed");
            }
            else if (checkModifications == 5)
            {
                int selectedRow = dataTables.CurrentRow.Index;

                NewInvoicePanel form = new NewInvoicePanel(this, userName,true);
                form.tbFactuurbedrag.Text = dataTables.Rows[selectedRow].Cells[2].Value.ToString();
                form.datePicker.Text = dataTables.Rows[selectedRow].Cells[3].Value.ToString();
                form.tbGrootboekrekeningnummer.Text = dataTables.Rows[selectedRow].Cells[4].Value.ToString();
                form.tbBtwCode.Text = dataTables.Rows[selectedRow].Cells[5].Value.ToString();
                form.Show();
            }
        }
        public int GetSelectedId(int cell)
        {
            DataGridViewRow row = dataTables.SelectedRows[0];
            int currentCustomerId = (int)row.Cells[cell].Value;
            return currentCustomerId;
        }

        private void OpenChangeVisibility(DataGridViewRow row, int cellNumber, string boolToEdit)
        {
            int selectedRow = dataTables.CurrentRow.Index;
            string dataName = "";
            for (int i = 0; i < 3; i++)
            {
                dataName += row.Cells[i].Value.ToString() + "\n";
            }
            bool value = false;
            if (dataTables.Rows[selectedRow].Cells[cellNumber -1].Value.ToString() == "true")
            {
                value = true;
            }
                
            ChangeVisibilityPanel changeVisibilityPanel = new ChangeVisibilityPanel(this, GetSelectedId(0), dataName, value, table, boolToEdit);
            changeVisibilityPanel.Show();
            this.Hide();
        }

        private void Btrefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            SqlConnector.Connect();
            string query;
            query = "SELECT * FROM " + table + " WHERE isVisible = 1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SqlConnector.connection);
            DataSet ds = new DataSet();
            try
            {
                dataAdapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DataTable temp = ds.Tables[0];

            dataTables.DataSource = temp;
            dataTables.ReadOnly = true;
        }
    }
}
