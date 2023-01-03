namespace BookBizMgntSys.GUI
{
    partial class FormMISManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMISManager));
            this.buttonhome = new System.Windows.Forms.Button();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.labelEFName = new System.Windows.Forms.Label();
            this.labelEmpLName = new System.Windows.Forms.Label();
            this.labelELName = new System.Windows.Forms.Label();
            this.labelERole = new System.Windows.Forms.Label();
            this.labelEEmail = new System.Windows.Forms.Label();
            this.labelEPhone = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxEmpFName = new System.Windows.Forms.TextBox();
            this.textBoxEmpLName = new System.Windows.Forms.TextBox();
            this.textBoxEmpRole = new System.Windows.Forms.TextBox();
            this.textBoxEmpEmail = new System.Windows.Forms.TextBox();
            this.buttonSaveEmp = new System.Windows.Forms.Button();
            this.buttonSearchEmp = new System.Windows.Forms.Button();
            this.buttonListEmp = new System.Windows.Forms.Button();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.textBoxSearchInfo = new System.Windows.Forms.TextBox();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.listViewMIS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBoxEmpPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonhome
            // 
            this.buttonhome.Image = ((System.Drawing.Image)(resources.GetObject("buttonhome.Image")));
            this.buttonhome.Location = new System.Drawing.Point(836, 12);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(49, 45);
            this.buttonhome.TabIndex = 13;
            this.buttonhome.Text = "  ";
            this.buttonhome.UseVisualStyleBackColor = true;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Location = new System.Drawing.Point(58, 41);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(51, 16);
            this.labelEmpID.TabIndex = 14;
            this.labelEmpID.Text = "Emp ID";
            // 
            // labelEFName
            // 
            this.labelEFName.AutoSize = true;
            this.labelEFName.Location = new System.Drawing.Point(58, 79);
            this.labelEFName.Name = "labelEFName";
            this.labelEFName.Size = new System.Drawing.Size(103, 16);
            this.labelEFName.TabIndex = 15;
            this.labelEFName.Text = "Emp First Name";
            // 
            // labelEmpLName
            // 
            this.labelEmpLName.AutoSize = true;
            this.labelEmpLName.Location = new System.Drawing.Point(178, 248);
            this.labelEmpLName.Name = "labelEmpLName";
            this.labelEmpLName.Size = new System.Drawing.Size(0, 16);
            this.labelEmpLName.TabIndex = 16;
            // 
            // labelELName
            // 
            this.labelELName.AutoSize = true;
            this.labelELName.Location = new System.Drawing.Point(58, 117);
            this.labelELName.Name = "labelELName";
            this.labelELName.Size = new System.Drawing.Size(103, 16);
            this.labelELName.TabIndex = 17;
            this.labelELName.Text = "Emp Last Name";
            // 
            // labelERole
            // 
            this.labelERole.AutoSize = true;
            this.labelERole.Location = new System.Drawing.Point(385, 41);
            this.labelERole.Name = "labelERole";
            this.labelERole.Size = new System.Drawing.Size(93, 16);
            this.labelERole.TabIndex = 18;
            this.labelERole.Text = "Emp Job Role";
            // 
            // labelEEmail
            // 
            this.labelEEmail.AutoSize = true;
            this.labelEEmail.Location = new System.Drawing.Point(385, 79);
            this.labelEEmail.Name = "labelEEmail";
            this.labelEEmail.Size = new System.Drawing.Size(72, 16);
            this.labelEEmail.TabIndex = 19;
            this.labelEEmail.Text = "Emp Email";
            // 
            // labelEPhone
            // 
            this.labelEPhone.AutoSize = true;
            this.labelEPhone.Location = new System.Drawing.Point(385, 117);
            this.labelEPhone.Name = "labelEPhone";
            this.labelEPhone.Size = new System.Drawing.Size(77, 16);
            this.labelEPhone.TabIndex = 20;
            this.labelEPhone.Text = "Emp Phone";
            this.labelEPhone.Click += new System.EventHandler(this.labelEPhone_Click);
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(181, 38);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(146, 22);
            this.textBoxEmpID.TabIndex = 21;
            // 
            // textBoxEmpFName
            // 
            this.textBoxEmpFName.Location = new System.Drawing.Point(181, 73);
            this.textBoxEmpFName.Name = "textBoxEmpFName";
            this.textBoxEmpFName.Size = new System.Drawing.Size(146, 22);
            this.textBoxEmpFName.TabIndex = 22;
            // 
            // textBoxEmpLName
            // 
            this.textBoxEmpLName.Location = new System.Drawing.Point(181, 111);
            this.textBoxEmpLName.Name = "textBoxEmpLName";
            this.textBoxEmpLName.Size = new System.Drawing.Size(146, 22);
            this.textBoxEmpLName.TabIndex = 23;
            // 
            // textBoxEmpRole
            // 
            this.textBoxEmpRole.Location = new System.Drawing.Point(511, 38);
            this.textBoxEmpRole.Name = "textBoxEmpRole";
            this.textBoxEmpRole.Size = new System.Drawing.Size(146, 22);
            this.textBoxEmpRole.TabIndex = 24;
            // 
            // textBoxEmpEmail
            // 
            this.textBoxEmpEmail.Location = new System.Drawing.Point(511, 79);
            this.textBoxEmpEmail.Name = "textBoxEmpEmail";
            this.textBoxEmpEmail.Size = new System.Drawing.Size(146, 22);
            this.textBoxEmpEmail.TabIndex = 25;
            // 
            // buttonSaveEmp
            // 
            this.buttonSaveEmp.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveEmp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEmp.Location = new System.Drawing.Point(243, 249);
            this.buttonSaveEmp.Name = "buttonSaveEmp";
            this.buttonSaveEmp.Size = new System.Drawing.Size(104, 33);
            this.buttonSaveEmp.TabIndex = 27;
            this.buttonSaveEmp.Text = "Save ";
            this.buttonSaveEmp.UseVisualStyleBackColor = false;
            this.buttonSaveEmp.Click += new System.EventHandler(this.buttonSaveEmp_Click);
            // 
            // buttonSearchEmp
            // 
            this.buttonSearchEmp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchEmp.Location = new System.Drawing.Point(389, 249);
            this.buttonSearchEmp.Name = "buttonSearchEmp";
            this.buttonSearchEmp.Size = new System.Drawing.Size(104, 32);
            this.buttonSearchEmp.TabIndex = 28;
            this.buttonSearchEmp.Text = "Search";
            this.buttonSearchEmp.UseVisualStyleBackColor = true;
            this.buttonSearchEmp.Click += new System.EventHandler(this.buttonSearchEmp_Click);
            // 
            // buttonListEmp
            // 
            this.buttonListEmp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListEmp.Location = new System.Drawing.Point(535, 248);
            this.buttonListEmp.Name = "buttonListEmp";
            this.buttonListEmp.Size = new System.Drawing.Size(104, 33);
            this.buttonListEmp.TabIndex = 29;
            this.buttonListEmp.Text = "List ";
            this.buttonListEmp.UseVisualStyleBackColor = true;
            this.buttonListEmp.Click += new System.EventHandler(this.buttonListEmp_Click);
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.AutoSize = true;
            this.labelSearchInfo.Location = new System.Drawing.Point(178, 163);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Size = new System.Drawing.Size(74, 16);
            this.labelSearchInfo.TabIndex = 30;
            this.labelSearchInfo.Text = "Search Info";
            // 
            // textBoxSearchInfo
            // 
            this.textBoxSearchInfo.Location = new System.Drawing.Point(181, 182);
            this.textBoxSearchInfo.Name = "textBoxSearchInfo";
            this.textBoxSearchInfo.Size = new System.Drawing.Size(146, 22);
            this.textBoxSearchInfo.TabIndex = 31;
            this.textBoxSearchInfo.TextChanged += new System.EventHandler(this.textBoxSearchInfo_TextChanged);
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(385, 185);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(69, 16);
            this.labelSearchBy.TabIndex = 32;
            this.labelSearchBy.Text = "Search By";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Emp ID",
            "Emp First Name",
            "Emp Last Name",
            "Emp Job Role"});
            this.comboBoxSearch.Location = new System.Drawing.Point(511, 180);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(146, 24);
            this.comboBoxSearch.TabIndex = 33;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listViewMIS
            // 
            this.listViewMIS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMIS.HideSelection = false;
            this.listViewMIS.Location = new System.Drawing.Point(24, 328);
            this.listViewMIS.Name = "listViewMIS";
            this.listViewMIS.Size = new System.Drawing.Size(838, 296);
            this.listViewMIS.TabIndex = 34;
            this.listViewMIS.UseCompatibleStateImageBehavior = false;
            this.listViewMIS.View = System.Windows.Forms.View.Details;
            this.listViewMIS.SelectedIndexChanged += new System.EventHandler(this.listViewMIS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emp ID";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Emp First Name";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Emp Last Name";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Emp Job Role";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Emp Email";
            this.columnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Emp Phone";
            this.columnHeader6.Width = 106;
            // 
            // maskedTextBoxEmpPhone
            // 
            this.maskedTextBoxEmpPhone.Location = new System.Drawing.Point(511, 110);
            this.maskedTextBoxEmpPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxEmpPhone.Name = "maskedTextBoxEmpPhone";
            this.maskedTextBoxEmpPhone.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxEmpPhone.TabIndex = 35;
            // 
            // FormMISManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(901, 645);
            this.Controls.Add(this.maskedTextBoxEmpPhone);
            this.Controls.Add(this.listViewMIS);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.textBoxSearchInfo);
            this.Controls.Add(this.labelSearchInfo);
            this.Controls.Add(this.buttonListEmp);
            this.Controls.Add(this.buttonSearchEmp);
            this.Controls.Add(this.buttonSaveEmp);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.textBoxEmpEmail);
            this.Controls.Add(this.textBoxEmpRole);
            this.Controls.Add(this.textBoxEmpLName);
            this.Controls.Add(this.textBoxEmpFName);
            this.Controls.Add(this.labelEPhone);
            this.Controls.Add(this.labelEEmail);
            this.Controls.Add(this.labelERole);
            this.Controls.Add(this.labelELName);
            this.Controls.Add(this.labelEmpLName);
            this.Controls.Add(this.labelEFName);
            this.Controls.Add(this.labelEmpID);
            this.Controls.Add(this.buttonhome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMISManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMISManager";
            this.Load += new System.EventHandler(this.FormMISManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelEFName;
        private System.Windows.Forms.Label labelEmpLName;
        private System.Windows.Forms.Label labelELName;
        private System.Windows.Forms.Label labelERole;
        private System.Windows.Forms.Label labelEEmail;
        private System.Windows.Forms.Label labelEPhone;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxEmpFName;
        private System.Windows.Forms.TextBox textBoxEmpLName;
        private System.Windows.Forms.TextBox textBoxEmpRole;
        private System.Windows.Forms.TextBox textBoxEmpEmail;
        private System.Windows.Forms.Button buttonSaveEmp;
        private System.Windows.Forms.Button buttonSearchEmp;
        private System.Windows.Forms.Button buttonListEmp;
        private System.Windows.Forms.Label labelSearchInfo;
        private System.Windows.Forms.TextBox textBoxSearchInfo;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ListView listViewMIS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmpPhone;
    }
}