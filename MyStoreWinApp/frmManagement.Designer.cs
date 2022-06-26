namespace MyStoreWinApp
{
    partial class frmManagement
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
            this.grpManagement = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpManagement
            // 
            this.grpManagement.Controls.Add(this.btnLogout);
            this.grpManagement.Controls.Add(this.dataGridView1);
            this.grpManagement.Controls.Add(this.btnSearch);
            this.grpManagement.Controls.Add(this.btnDelete);
            this.grpManagement.Controls.Add(this.btnUpdate);
            this.grpManagement.Controls.Add(this.btnInsert);
            this.grpManagement.Controls.Add(this.lblCity);
            this.grpManagement.Controls.Add(this.cboCity);
            this.grpManagement.Controls.Add(this.lblCountry);
            this.grpManagement.Controls.Add(this.cboCountry);
            this.grpManagement.Controls.Add(this.txtMemberName);
            this.grpManagement.Controls.Add(this.txtMemberId);
            this.grpManagement.Controls.Add(this.lblMemberName);
            this.grpManagement.Controls.Add(this.lblMemberId);
            this.grpManagement.Location = new System.Drawing.Point(12, 12);
            this.grpManagement.Name = "grpManagement";
            this.grpManagement.Size = new System.Drawing.Size(797, 547);
            this.grpManagement.TabIndex = 0;
            this.grpManagement.TabStop = false;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(6, 23);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(110, 28);
            this.lblMemberId.TabIndex = 0;
            this.lblMemberId.Text = "Member ID";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemberName.Location = new System.Drawing.Point(6, 67);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(143, 28);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Member Name";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberId.Location = new System.Drawing.Point(153, 20);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(228, 34);
            this.txtMemberId.TabIndex = 2;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberName.Location = new System.Drawing.Point(153, 64);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(228, 34);
            this.txtMemberName.TabIndex = 3;
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(543, 20);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(228, 36);
            this.cboCountry.TabIndex = 4;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(416, 23);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(82, 28);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(416, 67);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 28);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // cboCity
            // 
            this.cboCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(543, 62);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(228, 36);
            this.cboCity.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(74, 119);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 47);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(254, 119);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 47);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(434, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(614, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 47);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(797, 286);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(344, 494);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 47);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 571);
            this.Controls.Add(this.grpManagement);
            this.Name = "frmManagement";
            this.Text = "Member Management";
            this.grpManagement.ResumeLayout(false);
            this.grpManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpManagement;
        private ComboBox cboCountry;
        private TextBox txtMemberName;
        private TextBox txtMemberId;
        private Label lblMemberName;
        private Label lblMemberId;
        private Button btnLogout;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label lblCity;
        private ComboBox cboCity;
        private Label lblCountry;
    }
}