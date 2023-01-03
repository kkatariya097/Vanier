using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.GUI
{
    public partial class FormOrderClerk : Form
    {
        public FormOrderClerk()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Close();


        }
    }
}
