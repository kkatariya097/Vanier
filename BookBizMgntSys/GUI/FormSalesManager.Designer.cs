namespace BookBizMgntSys.GUI
{
    partial class FormSalesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesManager));
            this.buttonhome = new System.Windows.Forms.Button();
            this.labelClientID = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostal = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFax = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.textBoxSearchInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonhome
            // 
            this.buttonhome.Image = ((System.Drawing.Image)(resources.GetObject("buttonhome.Image")));
            this.buttonhome.Location = new System.Drawing.Point(838, 12);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(51, 52);
            this.buttonhome.TabIndex = 0;
            this.buttonhome.Text = "  ";
            this.buttonhome.UseVisualStyleBackColor = true;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(129, 30);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(56, 16);
            this.labelClientID.TabIndex = 1;
            this.labelClientID.Text = "Client ID";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(441, 30);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(80, 16);
            this.labelClientName.TabIndex = 2;
            this.labelClientName.Text = "Client Name";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(129, 61);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(42, 16);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Street";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(129, 92);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // labelPostal
            // 
            this.labelPostal.AutoSize = true;
            this.labelPostal.Location = new System.Drawing.Point(129, 123);
            this.labelPostal.Name = "labelPostal";
            this.labelPostal.Size = new System.Drawing.Size(81, 16);
            this.labelPostal.TabIndex = 5;
            this.labelPostal.Text = "Postal Code";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(441, 61);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(46, 16);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone";
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(441, 92);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(29, 16);
            this.labelFax.TabIndex = 7;
            this.labelFax.Text = "Fax";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(441, 123);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 16);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email ID";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(223, 30);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(146, 22);
            this.textBoxClientID.TabIndex = 9;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(527, 30);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(146, 22);
            this.textBoxClientName.TabIndex = 10;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(223, 61);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(146, 22);
            this.textBoxStreet.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(223, 92);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(146, 22);
            this.textBoxCity.TabIndex = 12;
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Location = new System.Drawing.Point(223, 123);
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(146, 22);
            this.textBoxPostal.TabIndex = 13;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(527, 90);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(146, 22);
            this.textBoxFax.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(527, 120);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(146, 22);
            this.textBoxEmail.TabIndex = 16;
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.AutoSize = true;
            this.labelSearchInfo.Location = new System.Drawing.Point(242, 173);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Size = new System.Drawing.Size(74, 16);
            this.labelSearchInfo.TabIndex = 17;
            this.labelSearchInfo.Text = "Search Info";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(425, 173);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(69, 16);
            this.labelSearchBy.TabIndex = 18;
            this.labelSearchBy.Text = "Search By";
            // 
            // textBoxSearchInfo
            // 
            this.textBoxSearchInfo.Location = new System.Drawing.Point(245, 194);
            this.textBoxSearchInfo.Name = "textBoxSearchInfo";
            this.textBoxSearchInfo.Size = new System.Drawing.Size(146, 22);
            this.textBoxSearchInfo.TabIndex = 19;
            this.textBoxSearchInfo.TextChanged += new System.EventHandler(this.textBoxSearchInfo_TextChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Client ID",
            "Client Name",
            "Postal Code"});
            this.comboBoxSearch.Location = new System.Drawing.Point(428, 192);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(146, 24);
            this.comboBoxSearch.TabIndex = 20;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(262, 252);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 34);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(378, 252);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 34);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(497, 252);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(90, 34);
            this.buttonList.TabIndex = 23;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(24, 307);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(842, 315);
            this.listViewClient.TabIndex = 24;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client ID";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client Name";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Street";
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "City";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Postal Code";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phone ";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fax";
            this.columnHeader7.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email ID";
            this.columnHeader8.Width = 89;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(527, 58);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxPhone.TabIndex = 25;
            // 
            // FormSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(901, 645);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.textBoxSearchInfo);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.labelSearchInfo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFax);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPostal);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.buttonhome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalesManager";
            this.Load += new System.EventHandler(this.FormSalesManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostal;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSearchInfo;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.TextBox textBoxSearchInfo;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}