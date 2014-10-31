namespace barrocitWinform
{
    partial class ListboxPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(497, 337);
            // 
            // lblClock
            // 
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "10:02:43";
            // 
            // ListboxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Name = "ListboxPanel";
            this.Text = "ListboxPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}