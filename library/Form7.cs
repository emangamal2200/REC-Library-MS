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
    public partial class BorrowBook : Form
    {
        LibraryEntities2 db = new LibraryEntities2();
        public BorrowBook()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtBookName.Text == "" || txtBrby.Text == "" || txtBEmail.Text == "" || txtBdate.Text == "" || txtPhone.Text == ""))
            {
                AddBRecordData();
                ClearBRecordData();
                this.Hide();
                



            }
            else
            {
                MessageBox.Show("Enter Your Data First");
            }
        }
        private void AddBRecordData()

        {
            BRecord b = new BRecord();
            b.BookName = txtBookName.Text;
            b.BorrowedBy = txtBrby.Text;
            b.BorrowerEmail = txtBEmail.Text;
            b.BorrowingDate = txtBdate.Text;
            b.Phone = txtPhone.Text;
            db.BRecords.Add(b);
            db.SaveChanges();
            MessageBox.Show("The Record Was Saved Successfuley ,You Have 20 days Before Returning Your Book");


        }

        private void ClearBRecordData()
        {
            txtBookName.Text = "";
            txtBrby.Text = "";
            txtBEmail.Text = "";
            txtBdate.Text = "";
            txtPhone.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page ad = new Admin_Page();
            ad.ShowDialog();
        }
    }
}
