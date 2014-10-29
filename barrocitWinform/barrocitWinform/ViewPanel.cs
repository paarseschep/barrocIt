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
        /// <param name="lastPanel"> Always "This."</param>
        /// <param name="userName"> Username.</param>
        /// <param name="table">The string of the table you want to acces.</param>
        /// <param name="isReadOnly">True to not edit, false to edit.</param> 
        public ViewPanel(Form lastPanel, string userName, string table, bool isReadOnly)
        {
            InitializeComponent();
            this.lastPanel = lastPanel;
            string query = "SELECT * FROM " + table;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, SqlConnector.connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            DataTable temp = ds.Tables[0];

                    
            dataTables.DataSource = temp;
            dataTables.ReadOnly = isReadOnly;
        }
    }
}
