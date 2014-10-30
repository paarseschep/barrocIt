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
    public partial class NewCustomerPanel : DepartmentPanel
    {
        public NewCustomerPanel(Form lastPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = lastPanel;
            this.userName = userName;
            UpdateGreeting();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!checkEmptyTextboxes())
            {
                List<string> AllNewUserData = AddToList( tbFirstname.Text, tbLastname.Text, tbEmail.Text, tbPhone.Text, tbStreetnumber.Text, tbPostalcode.Text, tbCity.Text, tbProvince.Text, tbCompanyEmail.Text, tbCompanyPhone.Text, tbCompany.Text );

                string columsInRightOrder = " firstname, lastname, email, phonenumber, adress1, postalCode1, city1, email_company, phonenumber_company, companyName";
                SqlConnector.InsertDataIntoDatabase(AllNewUserData, columsInRightOrder, "Tbl_Customers");
            }
            else
            {
                MessageBox.Show("Please fill in al the red fields.");
            }
        }
        public List<string> AddToList(params string[] dataList)
        {
            return dataList.ToList();
        }
        private bool checkEmptyTextboxes()
        {
            bool containsEmptyTextbox = false;  
            foreach (object obj in this.Controls)
            {
                if (obj is TextBox && ((TextBox)obj).Text.Trim().Length == 0)
                {
                    containsEmptyTextbox = true;
                    ((TextBox)obj).BackColor = Color.Red;

                }
                else if (obj is TextBox && ((TextBox)obj).BackColor == Color.Red)
                {
                    ((TextBox)obj).BackColor = Color.White;
                }
            }
            return containsEmptyTextbox;
        }
        private void tb_Click(object sender, EventArgs e)
        {
            if((sender as TextBox).BackColor == Color.Red)
            {
                (sender as TextBox).BackColor = Color.White;
            }
            else if((sender as TextBox).BackColor == Color.White && ((TextBox)sender).Text.Trim().Length == 0)
            {
                (sender as TextBox).BackColor = Color.Red;
            }
        }
    }
}
