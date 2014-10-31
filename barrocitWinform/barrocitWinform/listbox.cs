using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    public class listbox : ListBox
    {
        Form parentpanel;
        public listbox(Form parentPanel)
        {
            this.parentpanel = parentpanel;
        }
        public listbox()
        {

        }
    }
}
