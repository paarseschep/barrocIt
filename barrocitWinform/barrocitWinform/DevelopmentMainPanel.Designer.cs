﻿namespace barrocitWinform
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
            this.btnViewProject = new System.Windows.Forms.Button();
            this.btEditProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(878, 680);
            this.btnBack.Size = new System.Drawing.Size(118, 37);
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(1373, 11);
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "13:41:57";
            // 
            // btnViewProject
            // 
            this.btnViewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProject.Location = new System.Drawing.Point(230, 126);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(459, 264);
            this.btnViewProject.TabIndex = 10;
            this.btnViewProject.Text = "View project";
            this.btnViewProject.UseVisualStyleBackColor = true;
            this.btnViewProject.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btEditProject
            // 
            this.btEditProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditProject.Location = new System.Drawing.Point(230, 413);
            this.btEditProject.Name = "btEditProject";
            this.btEditProject.Size = new System.Drawing.Size(459, 264);
            this.btEditProject.TabIndex = 11;
            this.btEditProject.Text = "Edit project";
            this.btEditProject.UseVisualStyleBackColor = true;
            this.btEditProject.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // DevelopmentMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btEditProject);
            this.Controls.Add(this.btnViewProject);
            this.Name = "DevelopmentMainPanel";
            this.Text = "DevelopmentMainPanel";
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnViewProject, 0);
            this.Controls.SetChildIndex(this.btEditProject, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.Button btEditProject;
    }
}