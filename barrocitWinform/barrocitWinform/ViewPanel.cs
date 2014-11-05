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
        public static bool isModifiedCustomer = false;
        public static int currentCustomerId;
        /// <param name="lastPanel"> Always "This."</param>
        /// <param name="userName"> Username.</param>
        /// <param name="table">The string of the table you want to acces.</param>
        /// <param name="isReadOnly">True to not edit, false to edit.</param> 
        public ViewPanel(Form lastPanel, string userName, string table, bool isReadOnly)
        {
            InitializeComponent();
            this.userName = userName;
            UpdateGreeting();
            Table = table;
            IsReadOnly = isReadOnly;

            this.lastPanel = lastPanel;
            string query;
            query = "SELECT * FROM " + table;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SqlConnector.connection);
            DataSet ds = new DataSet();
            try
            {
                dataAdapter.Fill(ds);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DataTable temp = ds.Tables[0];
    
            dataTables.DataSource = temp;
            dataTables.ReadOnly = isReadOnly;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataTables.ClearSelection();
            string name = tbSearch.Text;
            string query;
            if (name == "")
            {
                query = "SELECT * FROM " + Table;
            }
            else
            {
                query = "SELECT * FROM " + Table + " WHERE firstname = '" + name + "'";
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SqlConnector.connection);
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
            dataTables.ReadOnly = IsReadOnly;
        }

        private void dataTables_DoubleClick(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            this.Hide();
            if (isModifiedCustomer)
            {
                int update = dataTables.CurrentRow.Index;

                DataGridViewRow row = dataTables.SelectedRows[0];
                currentCustomerId = (int)row.Cells[0].Value;

                NewCustomerPanel form = new NewCustomerPanel(this, userName);
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
        }
    }
}
