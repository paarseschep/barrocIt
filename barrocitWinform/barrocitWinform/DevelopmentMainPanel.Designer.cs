namespace barrocitWinform
{
    partial class DevelopmentMainPanel
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
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(499, 327);
            // 
            // lblClock
            // 
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "14:26:09";
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteInvoice.Location = new System.Drawing.Point(225, 211);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(134, 47);
            this.btnDeleteInvoice.TabIndex = 11;
            this.btnDeleteInvoice.Text = "Delete project";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewInvoice.Location = new System.Drawing.Point(225, 158);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(134, 47);
            this.btnViewInvoice.TabIndex = 10;
            this.btnViewInvoice.Text = "View project";
            this.btnViewInvoice.UseVisualStyleBackColor = true;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInvoice.Location = new System.Drawing.Point(225, 105);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(134, 47);
            this.btnAddInvoice.TabIndex = 9;
            this.btnAddInvoice.Text = "Add project";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // DevelopmentMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnViewInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Name = "DevelopmentMainPanel";
            this.Text = "DevelopmentMainPanel";
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnAddInvoice, 0);
            this.Controls.SetChildIndex(this.btnViewInvoice, 0);
            this.Controls.SetChildIndex(this.btnDeleteInvoice, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnAddInvoice;
    }
}