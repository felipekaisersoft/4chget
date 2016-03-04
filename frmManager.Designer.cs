namespace _4chget
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.lblDLT = new System.Windows.Forms.Label();
            this.lbThreads = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblOP = new System.Windows.Forms.Label();
            this.txtOP = new System.Windows.Forms.RichTextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDLT
            // 
            this.lblDLT.AutoSize = true;
            this.lblDLT.Location = new System.Drawing.Point(12, 24);
            this.lblDLT.Name = "lblDLT";
            this.lblDLT.Size = new System.Drawing.Size(118, 15);
            this.lblDLT.TabIndex = 0;
            this.lblDLT.Text = "Downloaded threads: ";
            // 
            // lbThreads
            // 
            this.lbThreads.FormattingEnabled = true;
            this.lbThreads.ItemHeight = 15;
            this.lbThreads.Location = new System.Drawing.Point(12, 41);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(453, 229);
            this.lbThreads.TabIndex = 1;
            this.lbThreads.SelectedIndexChanged += new System.EventHandler(this.lbThreads_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(677, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(471, 41);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(29, 15);
            this.lblOP.TabIndex = 3;
            this.lblOP.Text = "OP: ";
            // 
            // txtOP
            // 
            this.txtOP.Location = new System.Drawing.Point(526, 41);
            this.txtOP.Name = "txtOP";
            this.txtOP.ReadOnly = true;
            this.txtOP.Size = new System.Drawing.Size(261, 61);
            this.txtOP.TabIndex = 4;
            this.txtOP.Text = "";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(471, 105);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(46, 15);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Details: ";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(526, 108);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(261, 134);
            this.txtDetails.TabIndex = 6;
            this.txtDetails.Text = "";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(677, 248);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(110, 23);
            this.btnOpenFolder.TabIndex = 7;
            this.btnOpenFolder.Text = "Open folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 283);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtOP);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.lblDLT);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDLT;
        private System.Windows.Forms.ListBox lbThreads;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.RichTextBox txtOP;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}