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
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnDevelopment = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(497, 327);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUsers.Location = new System.Drawing.Point(12, 112);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(134, 47);
            this.btnEditUsers.TabIndex = 8;
            this.btnEditUsers.Text = "Edit users";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            // 
            // btnDevelopment
            // 
            this.btnDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevelopment.Location = new System.Drawing.Point(12, 196);
            this.btnDevelopment.Name = "btnDevelopment";
            this.btnDevelopment.Size = new System.Drawing.Size(134, 47);
            this.btnDevelopment.TabIndex = 9;
            this.btnDevelopment.Text = "Development\r\ndepartment";
            this.btnDevelopment.UseVisualStyleBackColor = true;
            this.btnDevelopment.Click += new System.EventHandler(this.btnDevelopment_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinance.Location = new System.Drawing.Point(222, 196);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(134, 47);
            this.btnFinance.TabIndex = 10;
            this.btnFinance.Text = "Finance\r\ndepartment";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnSales
            // 
            this.btnSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSales.Location = new System.Drawing.Point(438, 196);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(134, 47);
            this.btnSales.TabIndex = 11;
            this.btnSales.Text = "Sales\r\ndepartment";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.btnDevelopment);
            this.Controls.Add(this.btnEditUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnEditUsers, 0);
            this.Controls.SetChildIndex(this.btnDevelopment, 0);
            this.Controls.SetChildIndex(this.btnFinance, 0);
            this.Controls.SetChildIndex(this.btnSales, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnDevelopment;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnSales;

    }
}