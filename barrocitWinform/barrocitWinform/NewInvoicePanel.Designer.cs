namespace barrocitWinform
{
    partial class NewInvoicePanel
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
            this.lbStreetnumber = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 694);
            // 
            // lblClock
            // 
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "09:46:13";
            // 
            // lbStreetnumber
            // 
            this.lbStreetnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreetnumber.Location = new System.Drawing.Point(58, 339);
            this.lbStreetnumber.Name = "lbStreetnumber";
            this.lbStreetnumber.Size = new System.Drawing.Size(101, 31);
            this.lbStreetnumber.TabIndex = 48;
            this.lbStreetnumber.Text = "Paid?";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(268, 308);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(281, 31);
            this.tbPhone.TabIndex = 36;
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(58, 308);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(122, 31);
            this.lbPhone.TabIndex = 47;
            this.lbPhone.Text = "BTW Code";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(268, 277);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(281, 31);
            this.tbEmail.TabIndex = 35;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(58, 277);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(204, 31);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Grootboekrekeningnummer";
            // 
            // lblLastname
            // 
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(58, 253);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(204, 31);
            this.lblLastname.TabIndex = 41;
            this.lblLastname.Text = "Invoice datum:";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(268, 230);
            this.tbFirstname.Multiline = true;
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(281, 31);
            this.tbFirstname.TabIndex = 33;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(58, 230);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(186, 36);
            this.lblFirstname.TabIndex = 38;
            this.lblFirstname.Text = "Factuurbedrag:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(891, 675);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(105, 42);
            this.btnApply.TabIndex = 50;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(268, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NewInvoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbStreetnumber);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Name = "NewInvoicePanel";
            this.Text = "NewInvoicePanel";
            this.Controls.SetChildIndex(this.lblFirstname, 0);
            this.Controls.SetChildIndex(this.tbFirstname, 0);
            this.Controls.SetChildIndex(this.lblLastname, 0);
            this.Controls.SetChildIndex(this.lbEmail, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.lbPhone, 0);
            this.Controls.SetChildIndex(this.tbPhone, 0);
            this.Controls.SetChildIndex(this.lbStreetnumber, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStreetnumber;
        public System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}