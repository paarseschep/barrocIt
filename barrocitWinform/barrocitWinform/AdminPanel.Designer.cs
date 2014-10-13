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
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnDevelopment = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Development\r\ndepartment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(222, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Finance\r\ndepartment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(438, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sales\r\ndepartment";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Controls.SetChildIndex(this.btnEditUsers, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDevelopment;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnFinances;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}