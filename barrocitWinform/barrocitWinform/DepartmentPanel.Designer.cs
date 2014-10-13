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
            this.pnOptions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnOptions.SuspendLayout();
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
            this.lblClock.Location = new System.Drawing.Point(523, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnOptions
            // 
            this.pnOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOptions.Controls.Add(this.btnLogout);
            this.pnOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOptions.Location = new System.Drawing.Point(0, 25);
            this.pnOptions.Name = "pnOptions";
            this.pnOptions.Size = new System.Drawing.Size(584, 337);
            this.pnOptions.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(496, 301);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // DepartmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pnOptions);
            this.Controls.Add(this.lblClock);
            this.Name = "DepartmentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartmentPanel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentPanel_FormClosed);
            this.pnOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clockUpdater;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel pnOptions;
        private System.Windows.Forms.Button btnLogout;
    }
}