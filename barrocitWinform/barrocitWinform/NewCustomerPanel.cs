﻿using System;
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
        public NewCustomerPanel(Form loginPanel, string userName)
        {
            InitializeComponent();
            this.lastPanel = loginPanel;
            this.userName = userName;
            UpdateGreeting();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string[] AllNewUserData = { tbFirstname.Text, tbLastname.Text, tbEmail.Text, tbPhone.Text, tbStreetnumber.Text, tbPostalcode.Text, tbCity.Text, tbProvince.Text, tbCompanyEmail.Text, tbCompanyPhone.Text, tbCompany.Text };
            string columsInRightOrder = " firstname, lastname, email, phonenumber, adress1, postalCode1, city1, email_company, phonenumber_company, companyName";
            SqlConnector.InsertDataIntoDatabase(AllNewUserData, columsInRightOrder, "Tbl_Customers");
            
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
