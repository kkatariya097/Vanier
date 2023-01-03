namespace BookBizMgntSys.GUI
{
    partial class FormInventoryController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventoryController));
            this.button1 = new System.Windows.Forms.Button();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelYearPub = new System.Windows.Forms.Label();
            this.labelQOH = new System.Windows.Forms.Label();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxOtherPub = new System.Windows.Forms.TextBox();
            this.labelOtherPub = new System.Windows.Forms.Label();
            this.comboBoxPubName = new System.Windows.Forms.ComboBox();
            this.groupBoxPublisher = new System.Windows.Forms.GroupBox();
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.textBoxSearchInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.groupBoxBook.SuspendLayout();
            this.groupBoxPublisher.SuspendLayout();
            this.groupBoxAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(892, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "  ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(19, 34);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(38, 16);
            this.labelISBN.TabIndex = 1;
            this.labelISBN.Text = "ISBN";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(19, 80);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 16);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Book Title";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(19, 126);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.labelUnitPrice.TabIndex = 3;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelYearPub
            // 
            this.labelYearPub.AutoSize = true;
            this.labelYearPub.Location = new System.Drawing.Point(19, 172);
            this.labelYearPub.Name = "labelYearPub";
            this.labelYearPub.Size = new System.Drawing.Size(99, 16);
            this.labelYearPub.TabIndex = 4;
            this.labelYearPub.Text = "Year Published";
            // 
            // labelQOH
            // 
            this.labelQOH.AutoSize = true;
            this.labelQOH.Location = new System.Drawing.Point(19, 218);
            this.labelQOH.Name = "labelQOH";
            this.labelQOH.Size = new System.Drawing.Size(109, 16);
            this.labelQOH.TabIndex = 5;
            this.labelQOH.Text = "Quantity on Hand";
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(6, 31);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(103, 16);
            this.labelPublisherName.TabIndex = 6;
            this.labelPublisherName.Text = "Publisher Name";
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.textBoxQOH);
            this.groupBoxBook.Controls.Add(this.textBoxYear);
            this.groupBoxBook.Controls.Add(this.textBoxUnitPrice);
            this.groupBoxBook.Controls.Add(this.textBoxTitle);
            this.groupBoxBook.Controls.Add(this.textBoxISBN);
            this.groupBoxBook.Controls.Add(this.labelISBN);
            this.groupBoxBook.Controls.Add(this.labelTitle);
            this.groupBoxBook.Controls.Add(this.labelQOH);
            this.groupBoxBook.Controls.Add(this.labelUnitPrice);
            this.groupBoxBook.Controls.Add(this.labelYearPub);
            this.groupBoxBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBook.Location = new System.Drawing.Point(34, 12);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(324, 252);
            this.groupBoxBook.TabIndex = 10;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Book Details";
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(141, 212);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(146, 22);
            this.textBoxQOH.TabIndex = 12;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(141, 165);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(146, 22);
            this.textBoxYear.TabIndex = 11;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(141, 119);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(146, 22);
            this.textBoxUnitPrice.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(141, 73);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(146, 22);
            this.textBoxTitle.TabIndex = 9;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(141, 31);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(146, 22);
            this.textBoxISBN.TabIndex = 8;
            // 
            // textBoxOtherPub
            // 
            this.textBoxOtherPub.Location = new System.Drawing.Point(115, 74);
            this.textBoxOtherPub.Name = "textBoxOtherPub";
            this.textBoxOtherPub.Size = new System.Drawing.Size(146, 22);
            this.textBoxOtherPub.TabIndex = 17;
            // 
            // labelOtherPub
            // 
            this.labelOtherPub.AutoSize = true;
            this.labelOtherPub.Location = new System.Drawing.Point(86, 55);
            this.labelOtherPub.Name = "labelOtherPub";
            this.labelOtherPub.Size = new System.Drawing.Size(39, 16);
            this.labelOtherPub.TabIndex = 15;
            this.labelOtherPub.Text = "Other";
            // 
            // comboBoxPubName
            // 
            this.comboBoxPubName.FormattingEnabled = true;
            this.comboBoxPubName.Items.AddRange(new object[] {
            "Premier Press",
            "Wrox",
            "Murach",
            "Prentice Hall",
            "Other.... "});
            this.comboBoxPubName.Location = new System.Drawing.Point(115, 28);
            this.comboBoxPubName.Name = "comboBoxPubName";
            this.comboBoxPubName.Size = new System.Drawing.Size(146, 24);
            this.comboBoxPubName.TabIndex = 13;
            // 
            // groupBoxPublisher
            // 
            this.groupBoxPublisher.Controls.Add(this.labelPublisherName);
            this.groupBoxPublisher.Controls.Add(this.comboBoxPubName);
            this.groupBoxPublisher.Controls.Add(this.labelOtherPub);
            this.groupBoxPublisher.Controls.Add(this.textBoxOtherPub);
            this.groupBoxPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPublisher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxPublisher.Location = new System.Drawing.Point(375, 12);
            this.groupBoxPublisher.Name = "groupBoxPublisher";
            this.groupBoxPublisher.Size = new System.Drawing.Size(278, 108);
            this.groupBoxPublisher.TabIndex = 20;
            this.groupBoxPublisher.TabStop = false;
            this.groupBoxPublisher.Text = "Publisher Details";
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.textBoxAuthor);
            this.groupBoxAuthor.Location = new System.Drawing.Point(375, 131);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(278, 133);
            this.groupBoxAuthor.TabIndex = 21;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Author Details";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(19, 31);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(232, 84);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // listViewBook
            // 
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewBook.HideSelection = false;
            this.listViewBook.Location = new System.Drawing.Point(34, 291);
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(896, 342);
            this.listViewBook.TabIndex = 22;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book Title";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year Pub.";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "QOH";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Publisher Name";
            this.columnHeader6.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Author Name";
            this.columnHeader7.Width = 99;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(696, 131);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(146, 41);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(696, 187);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(146, 41);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(696, 243);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(146, 41);
            this.buttonList.TabIndex = 25;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.AutoSize = true;
            this.labelSearchInfo.Location = new System.Drawing.Point(690, 12);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Size = new System.Drawing.Size(74, 16);
            this.labelSearchInfo.TabIndex = 26;
            this.labelSearchInfo.Text = "Search Info";
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(693, 71);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(69, 16);
            this.labelSearchBy.TabIndex = 27;
            this.labelSearchBy.Text = "Search By";
            // 
            // textBoxSearchInfo
            // 
            this.textBoxSearchInfo.Location = new System.Drawing.Point(696, 37);
            this.textBoxSearchInfo.Name = "textBoxSearchInfo";
            this.textBoxSearchInfo.Size = new System.Drawing.Size(146, 22);
            this.textBoxSearchInfo.TabIndex = 28;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "ISBN",
            "Title",
            "Publisher Name",
            "Author Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(696, 92);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(146, 24);
            this.comboBoxSearchBy.TabIndex = 29;
            // 
            // FormInventoryController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(954, 645);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxSearchInfo);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.labelSearchInfo);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.groupBoxAuthor);
            this.Controls.Add(this.groupBoxPublisher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInventoryController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventoryController";
            this.Load += new System.EventHandler(this.FormInventoryController_Load);
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.groupBoxPublisher.ResumeLayout(false);
            this.groupBoxPublisher.PerformLayout();
            this.groupBoxAuthor.ResumeLayout(false);
            this.groupBoxAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelYearPub;
        private System.Windows.Forms.Label labelQOH;
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxOtherPub;
        private System.Windows.Forms.Label labelOtherPub;
        private System.Windows.Forms.ComboBox comboBoxPubName;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxPublisher;
        private System.Windows.Forms.GroupBox groupBoxAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Label labelSearchInfo;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.TextBox textBoxSearchInfo;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}