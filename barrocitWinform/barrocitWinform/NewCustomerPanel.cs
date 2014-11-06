using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    public partial class NewCustomerPanel : DepartmentPanel
    {
        public static bool isCustomerAdded = false; 
        public NewCustomerPanel(Form lastPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = lastPanel;
            this.userName = userName;
            UpdateGreeting();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (FieldValidator.CheckFilledTextBoxes(this) && FieldValidator.AreFieldsValid(this))
                {
                    if (ViewPanel.checkModifications == 0)
                    {
                        List<string> AllNewUserData = AddToList(tbFirstname.Text, tbLastname.Text, tbCompany.Text, tbCompanyEmail.Text, tbCompanyPhone.Text, tbEmail.Text, tbPostalcode.Text, tbCity.Text, tbStreetnumber.Text, tbProvince.Text, tbPhone.Text, tbFaxnumber.Text, tbInsurance.Text);
                        string columsInRightOrder = " firstname, lastname, companyName, email_company, phonenumber_company, email, postalCode1, city1, homenumber, province, phonenumber, faxnumber, insurance_id";
                        SqlConnector.modifieDatabase(AllNewUserData, columsInRightOrder, "Tbl_Customers");
                        isCustomerAdded = true;
                    }
                    else
                    {
                        List<string> AllNewUserData = AddToList(tbFirstname.Text, tbLastname.Text, tbEmail.Text, tbPhone.Text, tbStreetnumber.Text, tbPostalcode.Text, tbCity.Text, tbProvince.Text, tbCompanyEmail.Text, tbCompanyPhone.Text, tbCompany.Text, tbInsurance.Text, tbFaxnumber.Text);
                        string columsInRightOrder = " firstname, lastname, email, phonenumber, homenumber, postalCode1, city1, province, email_company, phonenumber_company, companyName, insurance_id, faxnumber";
                        SqlConnector.InsertDataIntoDatabase(AllNewUserData, columsInRightOrder, "Tbl_Customers");
                        isCustomerAdded = true;
                    }
                }
                else
                {
                    isCustomerAdded = false;
                    MessageBox.Show("Please insert the right values.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (isCustomerAdded)
                {
                    if (ViewPanel.checkModifications == 0)
                    {
                        MessageBox.Show("You have succesfully modified a customer, this form will close now.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You have succesfully added a customer, this form will close now.");
                        this.Close();
                    }
                }
            }
        }
        public List<string> AddToList(params string[] dataList)
        {
            return dataList.ToList();
        }
    }
}
