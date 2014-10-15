namespace barrocitWinform
{
    partial class SalesMainPanelcs
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
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnMaganeCustomers = new System.Windows.Forms.Button();
            this.btnDeactivateCustomers = new System.Windows.Forms.Button();
            this.btnManageProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(120, 117);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(142, 38);
            this.btnCreateCustomer.TabIndex = 0;
            this.btnCreateCustomer.Text = "Create customers";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnMaganeCustomers
            // 
            this.btnMaganeCustomers.Location = new System.Drawing.Point(120, 161);
            this.btnMaganeCustomers.Name = "btnMaganeCustomers";
            this.btnMaganeCustomers.Size = new System.Drawing.Size(142, 38);
            this.btnMaganeCustomers.TabIndex = 1;
            this.btnMaganeCustomers.Text = "Manage customers";
            this.btnMaganeCustomers.UseVisualStyleBackColor = true;
            // 
            // btnDeactivateCustomers
            // 
            this.btnDeactivateCustomers.Location = new System.Drawing.Point(120, 205);
            this.btnDeactivateCustomers.Name = "btnDeactivateCustomers";
            this.btnDeactivateCustomers.Size = new System.Drawing.Size(142, 38);
            this.btnDeactivateCustomers.TabIndex = 2;
            this.btnDeactivateCustomers.Text = "De-activate customers";
            this.btnDeactivateCustomers.UseVisualStyleBackColor = true;
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.Location = new System.Drawing.Point(350, 117);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(138, 82);
            this.btnManageProjects.TabIndex = 3;
            this.btnManageProjects.Text = "Manage projects";
            this.btnManageProjects.UseVisualStyleBackColor = true;
            // 
            // SalesMainPanelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 382);
            this.Controls.Add(this.btnManageProjects);
            this.Controls.Add(this.btnDeactivateCustomers);
            this.Controls.Add(this.btnMaganeCustomers);
            this.Controls.Add(this.btnCreateCustomer);
            this.Name = "SalesMainPanelcs";
            this.Text = "SalesMainPanelcs";
            this.Controls.SetChildIndex(this.btnCreateCustomer, 0);
            this.Controls.SetChildIndex(this.btnMaganeCustomers, 0);
            this.Controls.SetChildIndex(this.btnDeactivateCustomers, 0);
            this.Controls.SetChildIndex(this.btnManageProjects, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnMaganeCustomers;
        private System.Windows.Forms.Button btnDeactivateCustomers;
        private System.Windows.Forms.Button btnManageProjects;
    }
}