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
            this.Btrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 659);
            this.btnBack.Size = new System.Drawing.Size(141, 58);
            // 
            // lblClock
            // 
            this.lblClock.Size = new System.Drawing.Size(49, 13);
            this.lblClock.Text = "09:37:39";
            // 
            // dataTables
            // 
            this.dataTables.AllowUserToAddRows = false;
            this.dataTables.AllowUserToDeleteRows = false;
            this.dataTables.AllowUserToResizeColumns = false;
            this.dataTables.AllowUserToResizeRows = false;
            this.dataTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTables.Location = new System.Drawing.Point(12, 28);
            this.dataTables.Name = "dataTables";
            this.dataTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTables.Size = new System.Drawing.Size(984, 625);
            this.dataTables.TabIndex = 9;
            this.dataTables.DoubleClick += new System.EventHandler(this.dataTables_DoubleClick);
            // 
            // Btrefresh
            // 
            this.Btrefresh.Location = new System.Drawing.Point(850, 659);
            this.Btrefresh.Name = "Btrefresh";
            this.Btrefresh.Size = new System.Drawing.Size(146, 58);
            this.Btrefresh.TabIndex = 12;
            this.Btrefresh.Text = "Refresh";
            this.Btrefresh.UseVisualStyleBackColor = true;
            this.Btrefresh.Click += new System.EventHandler(this.Btrefresh_Click);
            // 
            // ViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Btrefresh);
            this.Controls.Add(this.dataTables);
            this.Name = "ViewPanel";
            this.Text = "ViewWindow";
            this.Controls.SetChildIndex(this.lblClock, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.dataTables, 0);
            this.Controls.SetChildIndex(this.Btrefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dataTables;
        private System.Windows.Forms.Button Btrefresh;


    }
}