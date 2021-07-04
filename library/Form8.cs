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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page ad = new Admin_Page();
            ad.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
