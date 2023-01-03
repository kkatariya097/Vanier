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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMISManager_Click(object sender, EventArgs e)
        {
            Login obj = new Login(1);
            obj.Show();
            this.Hide();
        }

        private void buttonSalesManager_Click(object sender, EventArgs e)
        {
            Login obj = new Login(2);
            obj.Show();
            this.Hide();
        }

        private void buttonInvController_Click(object sender, EventArgs e)
        {
            Login obj = new Login(3);
            obj.Show();
            this.Hide();
        }

        private void buttonOrderClerks_Click(object sender, EventArgs e)
        {
            Login obj = new Login(4);
            obj.Show();
            this.Hide();
        }
    }
}
