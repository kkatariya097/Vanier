namespace BookBizMgntSys.GUI
{
    partial class FormOrderClerk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderClerk));
            this.labelOrderID = new System.Windows.Forms.Label();
            this.labelmode = new System.Windows.Forms.Label();
            this.labelPub = new System.Windows.Forms.Label();
            this.labelbook = new System.Windows.Forms.Label();
            this.labelorderby = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelclerk = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxorderid = new System.Windows.Forms.TextBox();
            this.comboBoxReceivedby = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderby = new System.Windows.Forms.ComboBox();
            this.comboBoxClerk = new System.Windows.Forms.ComboBox();
            this.textBoxBookname = new System.Windows.Forms.TextBox();
            this.textBoxauthorname = new System.Windows.Forms.TextBox();
            this.textBoxpubname = new System.Windows.Forms.TextBox();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.labelSearchby = new System.Windows.Forms.Label();
            this.comboBoxsearchby = new System.Windows.Forms.ComboBox();
            this.textBoxsearchinfo = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCalculateTotal = new System.Windows.Forms.Button();
            this.labeltotal = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(36, 27);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(57, 16);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID";
            // 
            // labelmode
            // 
            this.labelmode.AutoSize = true;
            this.labelmode.Location = new System.Drawing.Point(36, 59);
            this.labelmode.Name = "labelmode";
            this.labelmode.Size = new System.Drawing.Size(121, 16);
            this.labelmode.TabIndex = 1;
            this.labelmode.Text = "Order Received by";
            // 
            // labelPub
            // 
            this.labelPub.AutoSize = true;
            this.labelPub.Location = new System.Drawing.Point(341, 91);
            this.labelPub.Name = "labelPub";
            this.labelPub.Size = new System.Drawing.Size(100, 16);
            this.labelPub.TabIndex = 2;
            this.labelPub.Text = "Publisher name";
            // 
            // labelbook
            // 
            this.labelbook.AutoSize = true;
            this.labelbook.Location = new System.Drawing.Point(341, 27);
            this.labelbook.Name = "labelbook";
            this.labelbook.Size = new System.Drawing.Size(79, 16);
            this.labelbook.TabIndex = 3;
            this.labelbook.Text = "Book Name";
            // 
            // labelorderby
            // 
            this.labelorderby.AutoSize = true;
            this.labelorderby.Location = new System.Drawing.Point(36, 91);
            this.labelorderby.Name = "labelorderby";
            this.labelorderby.Size = new System.Drawing.Size(60, 16);
            this.labelorderby.TabIndex = 4;
            this.labelorderby.Text = "Order By";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(341, 123);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(55, 16);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelclerk
            // 
            this.labelclerk.AutoSize = true;
            this.labelclerk.Location = new System.Drawing.Point(36, 123);
            this.labelclerk.Name = "labelclerk";
            this.labelclerk.Size = new System.Drawing.Size(86, 16);
            this.labelclerk.TabIndex = 6;
            this.labelclerk.Text = "Cleark Name";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(341, 59);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(82, 16);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "Author name";
            // 
            // textBoxorderid
            // 
            this.textBoxorderid.Location = new System.Drawing.Point(170, 20);
            this.textBoxorderid.Name = "textBoxorderid";
            this.textBoxorderid.Size = new System.Drawing.Size(121, 22);
            this.textBoxorderid.TabIndex = 8;
            // 
            // comboBoxReceivedby
            // 
            this.comboBoxReceivedby.FormattingEnabled = true;
            this.comboBoxReceivedby.Items.AddRange(new object[] {
            "Email",
            "Telephone",
            "Fax"});
            this.comboBoxReceivedby.Location = new System.Drawing.Point(170, 50);
            this.comboBoxReceivedby.Name = "comboBoxReceivedby";
            this.comboBoxReceivedby.Size = new System.Drawing.Size(121, 24);
            this.comboBoxReceivedby.TabIndex = 9;
            // 
            // comboBoxOrderby
            // 
            this.comboBoxOrderby.FormattingEnabled = true;
            this.comboBoxOrderby.Location = new System.Drawing.Point(170, 91);
            this.comboBoxOrderby.Name = "comboBoxOrderby";
            this.comboBoxOrderby.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderby.TabIndex = 10;
            // 
            // comboBoxClerk
            // 
            this.comboBoxClerk.FormattingEnabled = true;
            this.comboBoxClerk.Items.AddRange(new object[] {
            "Clerk 1",
            "Clerk 2"});
            this.comboBoxClerk.Location = new System.Drawing.Point(170, 123);
            this.comboBoxClerk.Name = "comboBoxClerk";
            this.comboBoxClerk.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClerk.TabIndex = 11;
            // 
            // textBoxBookname
            // 
            this.textBoxBookname.Location = new System.Drawing.Point(462, 20);
            this.textBoxBookname.Name = "textBoxBookname";
            this.textBoxBookname.Size = new System.Drawing.Size(100, 22);
            this.textBoxBookname.TabIndex = 12;
            // 
            // textBoxauthorname
            // 
            this.textBoxauthorname.Location = new System.Drawing.Point(462, 59);
            this.textBoxauthorname.Name = "textBoxauthorname";
            this.textBoxauthorname.Size = new System.Drawing.Size(100, 22);
            this.textBoxauthorname.TabIndex = 13;
            // 
            // textBoxpubname
            // 
            this.textBoxpubname.Location = new System.Drawing.Point(462, 91);
            this.textBoxpubname.Name = "textBoxpubname";
            this.textBoxpubname.Size = new System.Drawing.Size(100, 22);
            this.textBoxpubname.TabIndex = 14;
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.Location = new System.Drawing.Point(462, 124);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxquantity.TabIndex = 15;
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.AutoSize = true;
            this.labelSearchInfo.Location = new System.Drawing.Point(640, 25);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Size = new System.Drawing.Size(74, 16);
            this.labelSearchInfo.TabIndex = 16;
            this.labelSearchInfo.Text = "Search Info";
            // 
            // labelSearchby
            // 
            this.labelSearchby.AutoSize = true;
            this.labelSearchby.Location = new System.Drawing.Point(643, 91);
            this.labelSearchby.Name = "labelSearchby";
            this.labelSearchby.Size = new System.Drawing.Size(69, 16);
            this.labelSearchby.TabIndex = 17;
            this.labelSearchby.Text = "Search By";
            // 
            // comboBoxsearchby
            // 
            this.comboBoxsearchby.FormattingEnabled = true;
            this.comboBoxsearchby.Items.AddRange(new object[] {
            "Order ID",
            "Book Name",
            "Mode "});
            this.comboBoxsearchby.Location = new System.Drawing.Point(643, 124);
            this.comboBoxsearchby.Name = "comboBoxsearchby";
            this.comboBoxsearchby.Size = new System.Drawing.Size(121, 24);
            this.comboBoxsearchby.TabIndex = 18;
            // 
            // textBoxsearchinfo
            // 
            this.textBoxsearchinfo.Location = new System.Drawing.Point(643, 51);
            this.textBoxsearchinfo.Name = "textBoxsearchinfo";
            this.textBoxsearchinfo.Size = new System.Drawing.Size(121, 22);
            this.textBoxsearchinfo.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 275);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(905, 294);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(39, 194);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 34);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(170, 194);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(102, 34);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(311, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 34);
            this.button3.TabIndex = 23;
            this.button3.Text = "List";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateTotal
            // 
            this.buttonCalculateTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateTotal.Location = new System.Drawing.Point(446, 194);
            this.buttonCalculateTotal.Name = "buttonCalculateTotal";
            this.buttonCalculateTotal.Size = new System.Drawing.Size(163, 34);
            this.buttonCalculateTotal.TabIndex = 24;
            this.buttonCalculateTotal.Text = "Calculate Total";
            this.buttonCalculateTotal.UseVisualStyleBackColor = true;
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(687, 199);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(113, 23);
            this.labeltotal.TabIndex = 25;
            this.labeltotal.Text = "Total price";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(870, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 54);
            this.button5.TabIndex = 26;
            this.button5.Text = "  ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mode of Order";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Publication Name";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Book Name";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ordered By";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Clerk Name";
            this.columnHeader7.Width = 101;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Author name";
            this.columnHeader8.Width = 109;
            // 
            // FormOrderClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.buttonCalculateTotal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxsearchinfo);
            this.Controls.Add(this.comboBoxsearchby);
            this.Controls.Add(this.labelSearchby);
            this.Controls.Add(this.labelSearchInfo);
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.textBoxpubname);
            this.Controls.Add(this.textBoxauthorname);
            this.Controls.Add(this.textBoxBookname);
            this.Controls.Add(this.comboBoxClerk);
            this.Controls.Add(this.comboBoxOrderby);
            this.Controls.Add(this.comboBoxReceivedby);
            this.Controls.Add(this.textBoxorderid);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelclerk);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelorderby);
            this.Controls.Add(this.labelbook);
            this.Controls.Add(this.labelPub);
            this.Controls.Add(this.labelmode);
            this.Controls.Add(this.labelOrderID);
            this.Name = "FormOrderClerk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderClerk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Label labelmode;
        private System.Windows.Forms.Label labelPub;
        private System.Windows.Forms.Label labelbook;
        private System.Windows.Forms.Label labelorderby;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelclerk;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxorderid;
        private System.Windows.Forms.ComboBox comboBoxReceivedby;
        private System.Windows.Forms.ComboBox comboBoxOrderby;
        private System.Windows.Forms.ComboBox comboBoxClerk;
        private System.Windows.Forms.TextBox textBoxBookname;
        private System.Windows.Forms.TextBox textBoxauthorname;
        private System.Windows.Forms.TextBox textBoxpubname;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.Label labelSearchInfo;
        private System.Windows.Forms.Label labelSearchby;
        private System.Windows.Forms.ComboBox comboBoxsearchby;
        private System.Windows.Forms.TextBox textBoxsearchinfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCalculateTotal;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button button5;
    }
}