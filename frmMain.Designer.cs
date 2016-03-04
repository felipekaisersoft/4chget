namespace _4chget
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbSplitter = new System.Windows.Forms.PictureBox();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.lblVisit = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbOK = new System.Windows.Forms.PictureBox();
            this.btnODLF = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplitter)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL: ";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Location = new System.Drawing.Point(51, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(292, 23);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(349, 12);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(128, 23);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnDownload.Location = new System.Drawing.Point(50, 71);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(294, 53);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(349, 101);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(128, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbSplitter
            // 
            this.pbSplitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbSplitter.Location = new System.Drawing.Point(-1, 130);
            this.pbSplitter.Name = "pbSplitter";
            this.pbSplitter.Size = new System.Drawing.Size(490, 1);
            this.pbSplitter.TabIndex = 5;
            this.pbSplitter.TabStop = false;
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Location = new System.Drawing.Point(51, 41);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(165, 19);
            this.cbOpen.TabIndex = 6;
            this.cbOpen.Text = "Open folder after download";
            this.cbOpen.UseVisualStyleBackColor = true;
            // 
            // lblVisit
            // 
            this.lblVisit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVisit.AutoSize = true;
            this.lblVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVisit.Location = new System.Drawing.Point(220, 151);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(182, 15);
            this.lblVisit.TabIndex = 7;
            this.lblVisit.TabStop = true;
            this.lblVisit.Text = "Visit my website for more software!";
            this.lblVisit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVisit_LinkClicked);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 134);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(174, 15);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "Copyright © 2016 by Felipe Kaiser";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(12, 151);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(160, 15);
            this.lblLicense.TabIndex = 9;
            this.lblLicense.Text = "Licensed under the MIT License";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 167);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(489, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(39, 17);
            this.tslStatus.Text = "Ready";
            // 
            // pbOK
            // 
            this.pbOK.BackColor = System.Drawing.Color.Red;
            this.pbOK.Location = new System.Drawing.Point(50, 11);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(294, 25);
            this.pbOK.TabIndex = 11;
            this.pbOK.TabStop = false;
            // 
            // btnODLF
            // 
            this.btnODLF.Location = new System.Drawing.Point(349, 41);
            this.btnODLF.Name = "btnODLF";
            this.btnODLF.Size = new System.Drawing.Size(128, 24);
            this.btnODLF.TabIndex = 12;
            this.btnODLF.Text = "Open download folder";
            this.btnODLF.UseVisualStyleBackColor = true;
            this.btnODLF.Click += new System.EventHandler(this.btnODLF_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(349, 71);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(128, 24);
            this.btnManager.TabIndex = 13;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 189);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnODLF);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVisit);
            this.Controls.Add(this.cbOpen);
            this.Controls.Add(this.pbSplitter);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbOK);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "4chget";
            ((System.ComponentModel.ISupportInitialize)(this.pbSplitter)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbSplitter;
        private System.Windows.Forms.CheckBox cbOpen;
        private System.Windows.Forms.LinkLabel lblVisit;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.PictureBox pbOK;
        private System.Windows.Forms.Button btnODLF;
        private System.Windows.Forms.Button btnManager;
    }
}

