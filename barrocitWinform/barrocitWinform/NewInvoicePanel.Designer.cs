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
            this.tbBtwCode = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbGrootboekrekeningnummer = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbFactuurbedrag = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.customerBox1 = new barrocitWinform.CustomerBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 694);
            // 
            // lblClock
            // 
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "11:45:00";
            // 
            // lbStreetnumber
            // 
            this.lbStreetnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreetnumber.Location = new System.Drawing.Point(379, 394);
            this.lbStreetnumber.Name = "lbStreetnumber";
            this.lbStreetnumber.Size = new System.Drawing.Size(101, 31);
            this.lbStreetnumber.TabIndex = 48;
            this.lbStreetnumber.Text = "Paid";
            // 
            // tbBtwCode
            // 
            this.tbBtwCode.Location = new System.Drawing.Point(589, 352);
            this.tbBtwCode.Multiline = true;
            this.tbBtwCode.Name = "tbBtwCode";
            this.tbBtwCode.Size = new System.Drawing.Size(281, 31);
            this.tbBtwCode.TabIndex = 36;
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(379, 350);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(122, 31);
            this.lbPhone.TabIndex = 47;
            this.lbPhone.Text = "BTW Code";
            // 
            // tbGrootboekrekeningnummer
            // 
            this.tbGrootboekrekeningnummer.Location = new System.Drawing.Point(589, 302);
            this.tbGrootboekrekeningnummer.Multiline = true;
            this.tbGrootboekrekeningnummer.Name = "tbGrootboekrekeningnummer";
            this.tbGrootboekrekeningnummer.Size = new System.Drawing.Size(281, 31);
            this.tbGrootboekrekeningnummer.TabIndex = 35;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(379, 302);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(204, 31);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Grootboekrekeningnummer";
            // 
            // lblLastname
            // 
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(379, 265);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(204, 31);
            this.lblLastname.TabIndex = 41;
            this.lblLastname.Text = "Invoice date:";
            // 
            // tbFactuurbedrag
            // 
            this.tbFactuurbedrag.Location = new System.Drawing.Point(589, 216);
            this.tbFactuurbedrag.Multiline = true;
            this.tbFactuurbedrag.Name = "tbFactuurbedrag";
            this.tbFactuurbedrag.Size = new System.Drawing.Size(281, 31);
            this.tbFactuurbedrag.TabIndex = 33;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(379, 216);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(186, 36);
            this.lblFirstname.TabIndex = 38;
            this.lblFirstname.Text = "Factuurbedrag:";
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
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Location = new System.Drawing.Point(589, 399);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(15, 14);
            this.cbPaid.TabIndex = 51;
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(589, 265);
            this.datePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(235, 20);
            this.datePicker.TabIndex = 52;
            // 
            // customerBox1
            // 
            this.customerBox1.FormattingEnabled = true;
            this.customerBox1.Location = new System.Drawing.Point(12, 41);
            this.customerBox1.Name = "customerBox1";
            this.customerBox1.Size = new System.Drawing.Size(326, 537);
            this.customerBox1.TabIndex = 53;
            // 
            // NewInvoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.customerBox1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lbStreetnumber);
            this.Controls.Add(this.tbBtwCode);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbGrootboekrekeningnummer);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.tbFactuurbedrag);
            this.Controls.Add(this.lblFirstname);
            this.Name = "NewInvoicePanel";
            this.Text = "NewInvoicePanel";
            this.Controls.SetChildIndex(this.lblFirstname, 0);
            this.Controls.SetChildIndex(this.tbFactuurbedrag, 0);
            this.Controls.SetChildIndex(this.lblLastname, 0);
            this.Controls.SetChildIndex(this.lbEmail, 0);
            this.Controls.SetChildIndex(this.tbGrootboekrekeningnummer, 0);
            this.Controls.SetChildIndex(this.lbPhone, 0);
            this.Controls.SetChildIndex(this.tbBtwCode, 0);
            this.Controls.SetChildIndex(this.lbStreetnumber, 0);
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.cbPaid, 0);
            this.Controls.SetChildIndex(this.datePicker, 0);
            this.Controls.SetChildIndex(this.customerBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStreetnumber;
        public System.Windows.Forms.TextBox tbBtwCode;
        private System.Windows.Forms.Label lbPhone;
        public System.Windows.Forms.TextBox tbGrootboekrekeningnummer;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.TextBox tbFactuurbedrag;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbPaid;
        public System.Windows.Forms.DateTimePicker datePicker;
        private CustomerBox customerBox1;
    }
}