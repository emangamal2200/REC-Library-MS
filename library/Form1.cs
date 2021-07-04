using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn lo = new LogIn();
            lo.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
