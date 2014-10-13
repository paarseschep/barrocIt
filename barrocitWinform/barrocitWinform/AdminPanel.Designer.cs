namespace barrocitWinform
{
    partial class AdminPanel
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnOptions = new System.Windows.Forms.Panel();
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnDevelopment = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnOptions.SuspendLayout();
            this.SuspendLayout();
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnOptions
            // 
            this.pnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOptions.Controls.Add(this.btnFinances);
            this.pnOptions.Controls.Add(this.btnSales);
            this.pnOptions.Controls.Add(this.btnDevelopment);
            this.pnOptions.Controls.Add(this.btnUsers);
            this.pnOptions.Controls.Add(this.btnLogout);
            this.pnOptions.Location = new System.Drawing.Point(0, 25);
            this.pnOptions.Name = "pnOptions";
            this.pnOptions.Size = new System.Drawing.Size(584, 337);
            this.pnOptions.TabIndex = 3;
            // 
            // btnFinances
            // 
            this.btnFinances.Location = new System.Drawing.Point(385, 176);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(182, 41);
            this.btnFinances.TabIndex = 5;
            this.btnFinances.Text = "Finances\r\nDepartment";
            this.btnFinances.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(197, 176);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(182, 41);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales\r\nDepartment";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnDevelopment
            // 
            this.btnDevelopment.Location = new System.Drawing.Point(11, 176);
            this.btnDevelopment.Name = "btnDevelopment";
            this.btnDevelopment.Size = new System.Drawing.Size(182, 41);
            this.btnDevelopment.TabIndex = 3;
            this.btnDevelopment.Text = "Development\r\nDepartment";
            this.btnDevelopment.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(11, 86);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(182, 41);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Edit users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pnOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Controls.SetChildIndex(this.pnOptions, 0);
            this.pnOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnOptions;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDevelopment;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnFinances;

    }
}