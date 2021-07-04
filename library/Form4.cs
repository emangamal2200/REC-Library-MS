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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
            btn_Addbook.BackgroundImage = Properties.Resources.Addbooks;
            btnSearch.BackgroundImage = Properties.Resources.Search;
            btn_borrow.BackgroundImage = Properties.Resources.borrow_icon;
            btn_help.BackgroundImage = Properties.Resources.help;
        }

        

        private void btn_help_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help hh = new Help();
            hh.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook ab = new AddBook();
            ab.ShowDialog();
            

        }

        private void btn_Addbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search sh = new Search();
            sh.ShowDialog();
            
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowBook bb = new BorrowBook();
            bb.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hh = new Home();
            hh.ShowDialog();
        }
    }
}
