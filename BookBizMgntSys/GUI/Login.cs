using BookBizMgntSys.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookBizMgntSys
{
    public partial class Login : Form
    {
        private int user = 0;

        public Login()
        {
            InitializeComponent();
        }

        public Login(int _user)
        {
            InitializeComponent();
            CreateMyPasswordTextBox();
            user = _user;
        }

        public void CreateMyPasswordTextBox()
        {
            textBoxPassword.PasswordChar = '*';
        }




        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Equals("Admin") && textBoxPassword.Text.Equals("password") && user == 1)
            {
                FormMISManager formMISManager = new FormMISManager();
                formMISManager.Show();
                this.Hide();
            }

            else if (textBoxUsername.Text.Equals("Admin") && textBoxPassword.Text.Equals("password") && user == 2)
            {
                FormSalesManager formSalesManager = new FormSalesManager();
                formSalesManager.Show();
                this.Hide();
            }
            else if (textBoxUsername.Text.Equals("Admin") && textBoxPassword.Text.Equals("password") && user == 3)
            {
                FormInventoryController inventoryController = new FormInventoryController();
                inventoryController.Show();
                this.Hide();
            }
            else if (textBoxUsername.Text.Equals("Admin") && textBoxPassword.Text.Equals("password") && user == 4)
            {
                FormOrderClerk orderclerk = new FormOrderClerk();
                orderclerk.Show();
                this.Hide();
            }
            else
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();

                MessageBox.Show("Please enter correct credentials", "Incorrect Password");
            }
        }

        private void buttonhome_Click_1(object sender, EventArgs e)
        {
            FormHome homeobj = new FormHome();
            homeobj.Show();
            this.Close();
        }
    }
}
