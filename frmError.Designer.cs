namespace _4chget
{
    partial class frmError
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
            this.lblAEO = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAEO
            // 
            this.lblAEO.AutoSize = true;
            this.lblAEO.Location = new System.Drawing.Point(12, 9);
            this.lblAEO.Name = "lblAEO";
            this.lblAEO.Size = new System.Drawing.Size(99, 15);
            this.lblAEO.TabIndex = 0;
            this.lblAEO.Text = "An error occurred!";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(12, 42);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(256, 136);
            this.txtError.TabIndex = 1;
            this.txtError.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(256, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(12, 24);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(46, 15);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Details: ";
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 219);
            this.ControlBox = false;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblAEO);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAEO;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDetails;
    }
}