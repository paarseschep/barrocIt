namespace barrocitWinform
{
    partial class LoginPanel
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(119, 90);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(175, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(292, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(119, 155);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '♥';
            this.tbPassword.Size = new System.Drawing.Size(175, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // LbUsername
            // 
            this.LbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(116, 65);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(55, 13);
            this.LbUsername.TabIndex = 4;
            this.LbUsername.Text = "Username";
            // 
            // LbPassword
            // 
            this.LbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(116, 139);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(53, 13);
            this.LbPassword.TabIndex = 5;
            this.LbPassword.Text = "Password";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(12, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Button btnClose;
    }
}

