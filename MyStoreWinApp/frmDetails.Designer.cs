namespace MyStoreWinApp
{
    partial class frmDetails
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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnCancel);
            this.grpDetails.Controls.Add(this.btnSave);
            this.grpDetails.Controls.Add(this.cboCity);
            this.grpDetails.Controls.Add(this.cboCountry);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.lblCountry);
            this.grpDetails.Controls.Add(this.txtPassword);
            this.grpDetails.Controls.Add(this.lblPassword);
            this.grpDetails.Controls.Add(this.txtEmail);
            this.grpDetails.Controls.Add(this.lblEmail);
            this.grpDetails.Controls.Add(this.txtMemberName);
            this.grpDetails.Controls.Add(this.lblMemberName);
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(617, 217);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(351, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(153, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(418, 63);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(180, 28);
            this.cboCity.TabIndex = 9;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(418, 19);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(180, 28);
            this.cboCountry.TabIndex = 8;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(332, 23);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 20);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 27);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(134, 20);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(180, 27);
            this.txtMemberName.TabIndex = 1;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMemberName_TextChanged);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(19, 23);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(109, 20);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Name";
            this.lblMemberName.Click += new System.EventHandler(this.lblMemberName_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 241);
            this.Controls.Add(this.grpDetails);
            this.Name = "frmDetails";
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDetails;
        private ComboBox cboCity;
        private ComboBox cboCountry;
        private Label label1;
        private Label lblCountry;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtMemberName;
        private Label lblMemberName;
        private Button btnCancel;
        private Button btnSave;
    }
}