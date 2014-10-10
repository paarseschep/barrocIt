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
            this.lblClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockUpdater
            // 
            this.clockUpdater.Enabled = true;
            this.clockUpdater.Tick += new System.EventHandler(this.clockUpdater_Tick);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(519, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DepartmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.lblClock);
            this.Name = "DepartmentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clockUpdater;
        private System.Windows.Forms.Label lblClock;
    }
}