namespace _4chget
{
    partial class frmSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.cbSaveOP = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cobLanguage = new System.Windows.Forms.ComboBox();
            this.btnOSL = new System.Windows.Forms.Button();
            this.btnInstallURLHandler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(12, 189);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(128, 34);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save path: ";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(12, 33);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(262, 23);
            this.txtSavePath.TabIndex = 3;
            // 
            // cbSaveOP
            // 
            this.cbSaveOP.AutoSize = true;
            this.cbSaveOP.Location = new System.Drawing.Point(12, 106);
            this.cbSaveOP.Name = "cbSaveOP";
            this.cbSaveOP.Size = new System.Drawing.Size(73, 19);
            this.cbSaveOP.TabIndex = 7;
            this.cbSaveOP.Text = "Save OP?";
            this.cbSaveOP.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 160);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language: ";
            // 
            // cobLanguage
            // 
            this.cobLanguage.FormattingEnabled = true;
            this.cobLanguage.Location = new System.Drawing.Point(12, 77);
            this.cobLanguage.Name = "cobLanguage";
            this.cobLanguage.Size = new System.Drawing.Size(262, 23);
            this.cobLanguage.TabIndex = 10;
            this.cobLanguage.Text = "english.lang";
            // 
            // btnOSL
            // 
            this.btnOSL.Location = new System.Drawing.Point(93, 160);
            this.btnOSL.Name = "btnOSL";
            this.btnOSL.Size = new System.Drawing.Size(181, 23);
            this.btnOSL.TabIndex = 11;
            this.btnOSL.Text = "Open Source Licenses";
            this.btnOSL.UseVisualStyleBackColor = true;
            this.btnOSL.Click += new System.EventHandler(this.btnOSL_Click);
            // 
            // btnInstallURLHandler
            // 
            this.btnInstallURLHandler.Location = new System.Drawing.Point(12, 131);
            this.btnInstallURLHandler.Name = "btnInstallURLHandler";
            this.btnInstallURLHandler.Size = new System.Drawing.Size(262, 23);
            this.btnInstallURLHandler.TabIndex = 12;
            this.btnInstallURLHandler.Text = "Install URL Handler";
            this.btnInstallURLHandler.UseVisualStyleBackColor = true;
            this.btnInstallURLHandler.Click += new System.EventHandler(this.btnInstallURLHandler_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 235);
            this.Controls.Add(this.btnInstallURLHandler);
            this.Controls.Add(this.btnOSL);
            this.Controls.Add(this.cobLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cbSaveOP);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.CheckBox cbSaveOP;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobLanguage;
        private System.Windows.Forms.Button btnOSL;
        private System.Windows.Forms.Button btnInstallURLHandler;
    }
}