namespace BookBizMgntSys
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonMISManager = new System.Windows.Forms.Button();
            this.buttonSalesManager = new System.Windows.Forms.Button();
            this.buttonInvController = new System.Windows.Forms.Button();
            this.buttonOrderClerks = new System.Windows.Forms.Button();
            this.labelBBMSImage = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMISManager
            // 
            this.buttonMISManager.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMISManager.ForeColor = System.Drawing.Color.Black;
            this.buttonMISManager.Location = new System.Drawing.Point(549, 141);
            this.buttonMISManager.Name = "buttonMISManager";
            this.buttonMISManager.Size = new System.Drawing.Size(228, 54);
            this.buttonMISManager.TabIndex = 0;
            this.buttonMISManager.Text = "MIS Manager";
            this.buttonMISManager.UseVisualStyleBackColor = true;
            this.buttonMISManager.Click += new System.EventHandler(this.buttonMISManager_Click);
            // 
            // buttonSalesManager
            // 
            this.buttonSalesManager.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesManager.Location = new System.Drawing.Point(549, 215);
            this.buttonSalesManager.Name = "buttonSalesManager";
            this.buttonSalesManager.Size = new System.Drawing.Size(228, 54);
            this.buttonSalesManager.TabIndex = 1;
            this.buttonSalesManager.Text = "Sales Manager";
            this.buttonSalesManager.UseVisualStyleBackColor = true;
            this.buttonSalesManager.Click += new System.EventHandler(this.buttonSalesManager_Click);
            // 
            // buttonInvController
            // 
            this.buttonInvController.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvController.Location = new System.Drawing.Point(549, 289);
            this.buttonInvController.Name = "buttonInvController";
            this.buttonInvController.Size = new System.Drawing.Size(228, 54);
            this.buttonInvController.TabIndex = 2;
            this.buttonInvController.Text = "Inventory Controller";
            this.buttonInvController.UseVisualStyleBackColor = true;
            this.buttonInvController.Click += new System.EventHandler(this.buttonInvController_Click);
            // 
            // buttonOrderClerks
            // 
            this.buttonOrderClerks.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderClerks.Location = new System.Drawing.Point(549, 363);
            this.buttonOrderClerks.Name = "buttonOrderClerks";
            this.buttonOrderClerks.Size = new System.Drawing.Size(228, 54);
            this.buttonOrderClerks.TabIndex = 3;
            this.buttonOrderClerks.Text = "Order Clerks";
            this.buttonOrderClerks.UseVisualStyleBackColor = true;
            this.buttonOrderClerks.Click += new System.EventHandler(this.buttonOrderClerks_Click);
            // 
            // labelBBMSImage
            // 
            this.labelBBMSImage.AutoSize = true;
            this.labelBBMSImage.BackColor = System.Drawing.Color.Transparent;
            this.labelBBMSImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelBBMSImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBBMSImage.Image = ((System.Drawing.Image)(resources.GetObject("labelBBMSImage.Image")));
            this.labelBBMSImage.Location = new System.Drawing.Point(71, 32);
            this.labelBBMSImage.Name = "labelBBMSImage";
            this.labelBBMSImage.Size = new System.Drawing.Size(217, 135);
            this.labelBBMSImage.TabIndex = 4;
            this.labelBBMSImage.Text = "     ";
            this.labelBBMSImage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(41, 168);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(301, 68);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "          Book Biz \r\nManagement System";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.Color.Brown;
            this.labelAdd.Location = new System.Drawing.Point(90, 263);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(184, 154);
            this.labelAdd.TabIndex = 6;
            this.labelAdd.Text = "7122 18th Montreal, \r\nQuebec H2A2M8\r\n\r\nTel: (514) 721-8662\r\n\r\nFax: (514) 777-8665" +
    "\r\n\r\n";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBBMSImage);
            this.Controls.Add(this.buttonOrderClerks);
            this.Controls.Add(this.buttonInvController);
            this.Controls.Add(this.buttonSalesManager);
            this.Controls.Add(this.buttonMISManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMISManager;
        private System.Windows.Forms.Button buttonSalesManager;
        private System.Windows.Forms.Button buttonInvController;
        private System.Windows.Forms.Button buttonOrderClerks;
        private System.Windows.Forms.Label labelBBMSImage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAdd;
    }
}

