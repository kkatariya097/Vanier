namespace BookBizMgntSys
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBBMSImage = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // labelUsername
            // 
            this.labelUsername.AllowDrop = true;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(401, 240);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 19);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "User Name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 144);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(305, 23);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Book Biz Management System";
            // 
            // labelBBMSImage
            // 
            this.labelBBMSImage.AutoSize = true;
            this.labelBBMSImage.BackColor = System.Drawing.Color.Transparent;
            this.labelBBMSImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelBBMSImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBBMSImage.Image = ((System.Drawing.Image)(resources.GetObject("labelBBMSImage.Image")));
            this.labelBBMSImage.Location = new System.Drawing.Point(36, 9);
            this.labelBBMSImage.Name = "labelBBMSImage";
            this.labelBBMSImage.Size = new System.Drawing.Size(217, 135);
            this.labelBBMSImage.TabIndex = 6;
            this.labelBBMSImage.Text = "     ";
            // 
            // labelPassword
            // 
            this.labelPassword.AllowDrop = true;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(401, 282);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 19);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(506, 231);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(171, 28);
            this.textBoxUsername.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(506, 273);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(171, 28);
            this.textBoxPassword.TabIndex = 10;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(489, 337);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(86, 38);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.Image = ((System.Drawing.Image)(resources.GetObject("buttonhome.Image")));
            this.buttonhome.Location = new System.Drawing.Point(739, 393);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(49, 45);
            this.buttonhome.TabIndex = 12;
            this.buttonhome.Text = "  ";
            this.buttonhome.UseVisualStyleBackColor = true;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Id: Admin\r\npassword: password\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonhome);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBBMSImage);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBBMSImage;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Label label2;
    }
}