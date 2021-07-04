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
    public partial class Search : Form
    {
        LibraryEntities2 db = new LibraryEntities2();
        public Search()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
            dgvbookList.DataSource = db.books.ToList();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.book);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddltybe.SelectedValue.ToString());
            dgvbookList.DataSource = db.books.Where(x => x.Book_name.Contains(txtName.Text) && x.Book_Id == id).ToList();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvbookList.DataSource = db.books.Where(x => x.Book_name.Contains(txtName.Text) || x.Book_auther.Contains(txtName.Text)).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvbookList.DataSource = db.books.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page ad = new Admin_Page();
            ad.ShowDialog();
            
        }

        private void ddltybe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvbookList.DataSource = db.books.Where(x => x.publiching_year.Contains(ddltybe.Text)).ToList();

        }
    }
}
