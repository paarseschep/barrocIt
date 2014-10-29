namespace barrocitWinform
{
    partial class ViewPanel
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
            this.dataTables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.databaseset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(709, 327);
            // 
            // lblClock
            // 
            this.lblClock.Location = new System.Drawing.Point(737, 11);
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "12:29:11";
            // 
            // dataTables
            // 
            this.dataTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTables.Location = new System.Drawing.Point(12, 25);
            this.dataTables.Name = "dataTables";
            this.dataTables.Size = new System.Drawing.Size(772, 296);
            this.dataTables.TabIndex = 9;
            // 
            // ViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 362);
            this.Controls.Add(this.dataTables);
            this.Name = "ViewPanel";
            this.Text = "ViewWindow";
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.dataTables, 0);
            ((System.ComponentModel.ISupportInitialize)(this.databaseset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.DataGridView dataTables;


    }
}