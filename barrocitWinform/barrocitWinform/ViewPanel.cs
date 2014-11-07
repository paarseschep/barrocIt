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
        string Table;
        bool IsReadOnly;
        int checkModifications;
        //public static int currentCustomerId;
        /// <param name="lastPanel"> Always "This."</param>
        /// <param name="userName"> Username.</param>
        /// <param name="table">The string of the table you want to acces.</param>
        /// <param name="isReadOnly">True to not edit, false to edit.</param> 
        public ViewPanel(Form lastPanel, string userName, string table, int checkModifications)
        {
            InitializeComponent();

            this.userName = userName;
            this.checkModifications = checkModifications;
            UpdateGreeting();
            Table = table;

            if (checkModifications == 6)
            {
                dataTables.Enabled = false; 
            }
            this.lastPanel = lastPanel;
            Btrefresh.PerformClick();
        }

        private void dataTables_DoubleClick(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            this.Hide();
            if (checkModifications == 4)
            {
                int update = dataTables.CurrentRow.Index;

                int currenCustomerId = GetCurrentCustomerId(0);
                NewCustomerPanel form = new NewCustomerPanel(this, 4, userName);
                form.tbFirstname.Text = dataTables.Rows[update].Cells[1].Value.ToString();
                form.tbLastname.Text = dataTables.Rows[update].Cells[2].Value.ToString();
                form.tbCompany.Text = dataTables.Rows[update].Cells[3].Value.ToString();
                form.tbCompanyEmail.Text = dataTables.Rows[update].Cells[4].Value.ToString();
                form.tbCompanyPhone.Text = dataTables.Rows[update].Cells[5].Value.ToString();
                form.tbEmail.Text = dataTables.Rows[update].Cells[6].Value.ToString();
                form.tbPostalcode.Text = dataTables.Rows[update].Cells[7].Value.ToString();
                form.tbCity.Text = dataTables.Rows[update].Cells[8].Value.ToString();
                form.tbStreetnumber.Text = dataTables.Rows[update].Cells[9].Value.ToString();
                form.tbProvince.Text = dataTables.Rows[update].Cells[10].Value.ToString();
                form.tbPhone.Text = dataTables.Rows[update].Cells[11].Value.ToString();
                form.tbFaxnumber.Text = dataTables.Rows[update].Cells[12].Value.ToString();
                form.tbInsurance.Text = dataTables.Rows[update].Cells[13].Value.ToString();
                form.Show();
            }
            else if (checkModifications == 1)
            {
                int update = dataTables.CurrentRow.Index;

                NewProjectPanel form = new NewProjectPanel(this, GetCurrentCustomerId(1), checkModifications, userName);
                form.tbProjectName.Text = dataTables.Rows[update].Cells[2].Value.ToString();
                form.tbDescription.Text = dataTables.Rows[update].Cells[3].Value.ToString();
                form.datePicker.Text = dataTables.Rows[update].Cells[6].Value.ToString();
                form.tbPrice.Text = dataTables.Rows[update].Cells[7].Value.ToString();
                form.Show();
            }
            else if (checkModifications == 5)
            {
                int update = dataTables.CurrentRow.Index;

                NewInvoicePanel form = new NewInvoicePanel(this, userName);

            }
        }
        /// <summary>
        /// Gets the current selected customer ID.
        /// </summary>
        /// <param name="cell">Make it 0 to modify customer and 1 to modify project.</param>
        /// <returns></returns>
        public int GetCurrentCustomerId(int cell)
        {
            DataGridViewRow row = dataTables.SelectedRows[0];
            int currentCustomerId = (int)row.Cells[cell].Value;
            return currentCustomerId;
        }

        private void Btrefresh_Click(object sender, EventArgs e)
        {
            string query;
            query = "SELECT * FROM " + Table;
            SqlConnector.Connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SqlConnector.connectionString);
            DataSet ds = new DataSet();
            try
            {
                dataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable temp = ds.Tables[0];

            dataTables.DataSource = temp;
            dataTables.ReadOnly = false;
        }
    }
}
