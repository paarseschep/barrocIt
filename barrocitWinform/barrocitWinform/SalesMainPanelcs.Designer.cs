﻿namespace barrocitWinform
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
            this.btAddProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(881, 676);
            this.btnBack.Size = new System.Drawing.Size(115, 41);
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(947, 9);
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "09:34:48";
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(117, 89);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(322, 148);
            this.btnCreateCustomer.TabIndex = 0;
            this.btnCreateCustomer.Text = "Create customers";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnMaganeCustomers
            // 
            this.btnMaganeCustomers.Location = new System.Drawing.Point(117, 262);
            this.btnMaganeCustomers.Name = "btnMaganeCustomers";
            this.btnMaganeCustomers.Size = new System.Drawing.Size(322, 148);
            this.btnMaganeCustomers.TabIndex = 1;
            this.btnMaganeCustomers.Text = "Manage customers";
            this.btnMaganeCustomers.UseVisualStyleBackColor = true;
            this.btnMaganeCustomers.Click += new System.EventHandler(this.btnMaganeCustomers_Click);
            // 
            // btnDeactivateCustomers
            // 
            this.btnDeactivateCustomers.Location = new System.Drawing.Point(117, 439);
            this.btnDeactivateCustomers.Name = "btnDeactivateCustomers";
            this.btnDeactivateCustomers.Size = new System.Drawing.Size(322, 148);
            this.btnDeactivateCustomers.TabIndex = 2;
            this.btnDeactivateCustomers.Text = "De-activate customers";
            this.btnDeactivateCustomers.UseVisualStyleBackColor = true;
            this.btnDeactivateCustomers.Click += new System.EventHandler(this.btnDeactivateCustomers_Click);
            // 
            // btnManageProjects
            // 
            this.btnManageProjects.Location = new System.Drawing.Point(552, 89);
            this.btnManageProjects.Name = "btnManageProjects";
            this.btnManageProjects.Size = new System.Drawing.Size(322, 148);
            this.btnManageProjects.TabIndex = 3;
            this.btnManageProjects.Text = "Manage projects";
            this.btnManageProjects.UseVisualStyleBackColor = true;
            this.btnManageProjects.Click += new System.EventHandler(this.btnManageProjects_Click);
            // 
            // btAddProjects
            // 
            this.btAddProjects.Location = new System.Drawing.Point(552, 262);
            this.btAddProjects.Name = "btAddProjects";
            this.btAddProjects.Size = new System.Drawing.Size(322, 148);
            this.btAddProjects.TabIndex = 9;
            this.btAddProjects.Text = "Add projects";
            this.btAddProjects.UseVisualStyleBackColor = true;
            this.btAddProjects.Click += new System.EventHandler(this.btAddProjects_Click);
            // 
            // SalesMainPanelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btAddProjects);
            this.Controls.Add(this.btnManageProjects);
            this.Controls.Add(this.btnDeactivateCustomers);
            this.Controls.Add(this.btnMaganeCustomers);
            this.Controls.Add(this.btnCreateCustomer);
            this.Name = "SalesMainPanelcs";
            this.Text = "SalesMainPanelcs";
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnCreateCustomer, 0);
            this.Controls.SetChildIndex(this.btnMaganeCustomers, 0);
            this.Controls.SetChildIndex(this.btnDeactivateCustomers, 0);
            this.Controls.SetChildIndex(this.btnManageProjects, 0);
            this.Controls.SetChildIndex(this.btAddProjects, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnMaganeCustomers;
        private System.Windows.Forms.Button btnDeactivateCustomers;
        private System.Windows.Forms.Button btnManageProjects;
        private System.Windows.Forms.Button btAddProjects;
    }
}