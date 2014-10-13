namespace barrocitWinform
{
    partial class FinanceMainPanel
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
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnViewProjects = new System.Windows.Forms.Button();
            this.btnDeleteProjects = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(493, 327);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProject.Location = new System.Drawing.Point(105, 98);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(134, 47);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.Text = "Add project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            // 
            // btnViewProjects
            // 
            this.btnViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProjects.Location = new System.Drawing.Point(105, 151);
            this.btnViewProjects.Name = "btnViewProjects";
            this.btnViewProjects.Size = new System.Drawing.Size(134, 47);
            this.btnViewProjects.TabIndex = 4;
            this.btnViewProjects.Text = "View projects";
            this.btnViewProjects.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProjects
            // 
            this.btnDeleteProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProjects.Location = new System.Drawing.Point(105, 204);
            this.btnDeleteProjects.Name = "btnDeleteProjects";
            this.btnDeleteProjects.Size = new System.Drawing.Size(134, 47);
            this.btnDeleteProjects.TabIndex = 5;
            this.btnDeleteProjects.Text = "Delete projects";
            this.btnDeleteProjects.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteInvoice.Location = new System.Drawing.Point(332, 204);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(134, 47);
            this.btnDeleteInvoice.TabIndex = 8;
            this.btnDeleteInvoice.Text = "Delete invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(332, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "View invoices";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInvoice.Location = new System.Drawing.Point(332, 98);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(134, 47);
            this.btnAddInvoice.TabIndex = 6;
            this.btnAddInvoice.Text = "Add invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            // 
            // FinanceMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnDeleteProjects);
            this.Controls.Add(this.btnViewProjects);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnLogout);
            this.Name = "FinanceMainPanel";
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.btnAddProject, 0);
            this.Controls.SetChildIndex(this.btnViewProjects, 0);
            this.Controls.SetChildIndex(this.btnDeleteProjects, 0);
            this.Controls.SetChildIndex(this.btnAddInvoice, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.btnDeleteInvoice, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnViewProjects;
        private System.Windows.Forms.Button btnDeleteProjects;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddInvoice;

    }
}