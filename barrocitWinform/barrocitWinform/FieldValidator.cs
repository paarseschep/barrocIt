using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    static class FieldValidator
    {
        static public bool CheckFilledTextBoxes(Form form)
        {
            bool isTbFilled = false;
            foreach (object obj in form.Controls)
            {
                if (obj is TextBox)
                {
                    if (((TextBox)obj).Text != "")
                    {
                        isTbFilled = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return isTbFilled;
        }

        static public bool AreFieldsValid(Form form)
        {
            bool validFields = false;
            foreach (object obj in form.Controls)
            {
                if (((Control)obj).Name.Contains("Email") && ((Control)obj).Name.Contains("tb"))
                {
                    string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                    if (isRegexValid(((TextBox)obj).Text, strRegex))
                    {
                        validFields = true;
                    }
                    else
                    {
                        validFields = false;
                        break;
                    }
                }
                else if (((Control)obj).Name.Contains("Postalcode") && ((Control)obj).Name.Contains("tb"))
                {
                    string strRegex = @"^([1-9][0-9][0-9][0-9][a-zA-Z][a-zA-Z])$";

                    if (isRegexValid(((TextBox)obj).Text, strRegex))
                    {
                        validFields = true;
                    }
                    else
                    {
                        strRegex = @"^([1-9][0-9][0-9][0-9] [a-zA-Z][a-zA-Z])$";
                        if (isRegexValid(((TextBox)obj).Text, strRegex))
                        {
                            validFields = true;
                        }
                        else
                        {
                            validFields = false;
                            break;
                        }
                    }
                }
                else if (((Control)obj).Name.Contains("Phone") && ((Control)obj).Name.Contains("tb"))
                {
                    //string strRegex = @"^([0-9][0-9] [0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
                    string strRegex = @"^([0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
                    if (isRegexValid(((TextBox)obj).Text, strRegex))
                    {
                        validFields = true;
                    }
                    else
                    {
                        validFields = false;
                        break;
                    }
                }
            }
            return validFields;
        }

        static private bool isRegexValid(string data, string regex)
        {
            Regex reg = new Regex(regex);
            return reg.IsMatch(data);
        }
    }
}
