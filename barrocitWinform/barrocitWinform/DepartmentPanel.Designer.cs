namespace barrocitWinform
{
    partial class DepartmentPanel
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
            this.components = new System.ComponentModel.Container();
            this.clockUpdater = new System.Windows.Forms.Timer(this.components);
            this.lblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockUpdater
            // 
            this.clockUpdater.Enabled = true;
            this.clockUpdater.Interval = 1000;
            this.clockUpdater.Tick += new System.EventHandler(this.clockUpdater_Tick);
            // 
            // lblGreeting
            // 
            this.lblGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(406, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(58, 13);
            this.lblGreeting.TabIndex = 6;
            this.lblGreeting.Text = "Welcome, ";
            // 
            // DepartmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblGreeting);
            this.Name = "DepartmentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentPanel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clockUpdater;
        private System.Windows.Forms.Label lblGreeting;
    }
}