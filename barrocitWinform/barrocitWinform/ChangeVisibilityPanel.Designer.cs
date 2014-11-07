namespace barrocitWinform
{
    partial class ChangeVisibilityPanel
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
            this.btnApply = new System.Windows.Forms.Button();
            this.rbSetVisible = new System.Windows.Forms.RadioButton();
            this.rbSetInvisible = new System.Windows.Forms.RadioButton();
            this.lbData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 268);
            this.btnBack.Size = new System.Drawing.Size(113, 58);
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(854, 11);
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "14:00:16";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(788, 268);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 58);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rbSetVisible
            // 
            this.rbSetVisible.AutoSize = true;
            this.rbSetVisible.Checked = true;
            this.rbSetVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSetVisible.Location = new System.Drawing.Point(391, 141);
            this.rbSetVisible.Name = "rbSetVisible";
            this.rbSetVisible.Size = new System.Drawing.Size(112, 24);
            this.rbSetVisible.TabIndex = 10;
            this.rbSetVisible.TabStop = true;
            this.rbSetVisible.Text = "Make visible";
            this.rbSetVisible.UseVisualStyleBackColor = true;
            // 
            // rbSetInvisible
            // 
            this.rbSetInvisible.AutoSize = true;
            this.rbSetInvisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSetInvisible.Location = new System.Drawing.Point(391, 171);
            this.rbSetInvisible.Name = "rbSetInvisible";
            this.rbSetInvisible.Size = new System.Drawing.Size(124, 24);
            this.rbSetInvisible.TabIndex = 11;
            this.rbSetInvisible.Text = "Make invisible";
            this.rbSetInvisible.UseVisualStyleBackColor = true;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(391, 78);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(112, 60);
            this.lbData.TabIndex = 12;
            this.lbData.Text = "Selected data \r\ncomes \r\nhere\r\n";
            // 
            // ChangeVisibilityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 338);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.rbSetInvisible);
            this.Controls.Add(this.rbSetVisible);
            this.Controls.Add(this.btnApply);
            this.Name = "ChangeVisibilityPanel";
            this.Text = "ChangeVisibilityPanel";
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.rbSetVisible, 0);
            this.Controls.SetChildIndex(this.rbSetInvisible, 0);
            this.Controls.SetChildIndex(this.lbData, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbSetVisible;
        private System.Windows.Forms.RadioButton rbSetInvisible;
        private System.Windows.Forms.Label lbData;
    }
}