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

        private void dataTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> test = new List<string> ();
            //List<DataRow> dataRow = dataTables.CurrentRow.
            //foreach (string item in dataTables.CurrentRow.Cells.)
            //{
            //    test.add(item);
            //} 
        }
    }
}
