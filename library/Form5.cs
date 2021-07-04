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
    public partial class AddBook : Form
    {
        LibraryEntities2 db = new LibraryEntities2();
        public AddBook()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtBookName.Text == "" || txtAuther.Text == "" || txtPubby.Text == "" || txttype.Text == "" || txtyear.Text == ""))
            {
                AddBookData();
                ClearBookData();
                



            }
            else
            {
                MessageBox.Show("Enter Your Data First");
            }
        }
        private void AddBookData()
        {
           
            db.books.Add(new book{ Book_name = txtBookName.Text, Book_auther = txtAuther.Text, Published_by = txtPubby.Text, Book_tybe = txttype.Text, publiching_year = txtyear.Text });
            db.SaveChanges();
            MessageBox.Show("The Book Was Added Succesfully");


        }
        private void ClearBookData()
        {
            txtBookName.Text = "";
            txtAuther.Text = "";
            txtPubby.Text = "";
            txttype.Text = "";
            txtyear.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page ad = new Admin_Page();
            ad.ShowDialog();
            
        }
    }
}
