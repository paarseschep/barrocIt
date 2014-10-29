using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrocitWinform
{
    public class BackButton : Button
    {
        Form parentPanel;
        public string closeMessage;
        public BackButton(Form parentPanel)
        {
            this.parentPanel = parentPanel;
            this.Text = "Back";
            this.Click += BackButton_Click;
        }

        public void SetText(string buttonText, string closeMessage)
        {
            this.Text = buttonText;
            this.closeMessage = closeMessage;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            parentPanel.Close();
        }

    }
}
