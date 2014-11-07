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
            string query;
            query = "SELECT * FROM " + table;
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

            for (int i = 0; i < dataTables.Rows.Count; i++)
            {
                bool test = Convert.ToBoolean(dataTables.Rows[i].Cells[dataTables.Rows[i].Cells.Count -1].Value);
                if (!test)
                {
                    dataTables.Rows[i].Visible = false;
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataTables.ClearSelection();
            string name = tbSearch.Text;
            string query;
            if (name == "")
            {
                query = "SELECT * FROM " + table;
            }
            else
            {
                query = "SELECT * FROM " + table + " WHERE firstname = '" + name + "'";
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
            dataTables.ReadOnly = true;
        }

        private void dataTables_DoubleClick(object sender, EventArgs e)
        {
            SqlConnector.Connect();
            this.Hide();
            if (checkModifications == 0)
            {
                int selectedRow = dataTables.CurrentRow.Index;

                int currenCustomerId = GetCurrentCustomerId();
                NewCustomerPanel newCustomerPanel = new NewCustomerPanel(this, 0, userName);
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
            }
            else if (checkModifications == 1)
            {
                int selectedRow = dataTables.CurrentRow.Index;

                NewProjectPanel newProjectPanel = new NewProjectPanel(this, GetCurrentCustomerId(), checkModifications, userName);
                newProjectPanel.tbProjectName.Text = dataTables.Rows[selectedRow].Cells[2].Value.ToString();
                newProjectPanel.tbDescription.Text = dataTables.Rows[selectedRow].Cells[3].Value.ToString();
                newProjectPanel.datePicker.Text = dataTables.Rows[selectedRow].Cells[6].Value.ToString();
                newProjectPanel.tbPrice.Text = dataTables.Rows[selectedRow].Cells[7].Value.ToString();
                newProjectPanel.Show();
            }
            else if (checkModifications == 3)
            {
                int selectedRow = dataTables.CurrentRow.Index;

                string data = "";

                for (int i = 0; i < 3; i++)
                {
                    data += dataTables.Rows[selectedRow].Cells[i].Value.ToString() + " ";
                }

                ChangeVisibilityPanel changeVisibilityPanel = new ChangeVisibilityPanel(this, GetCurrentCustomerId(), data, table);
                changeVisibilityPanel.Show();
            }
            else if (checkModifications == 5)
            {

            }
        }
        public int GetCurrentCustomerId()
        {
            DataGridViewRow row = dataTables.SelectedRows[0];
            int currentCustomerId = (int)row.Cells[0].Value;
            return currentCustomerId;
        }
    }
}
