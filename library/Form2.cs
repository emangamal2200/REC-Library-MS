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
    public partial class Register : Form
    {
        LibraryEntities2 db = new LibraryEntities2();
        public Register()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(txtUserName.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == ""))
            {
                AddRegisterData();
                ClearRegisterData();
                this.Hide();
                Admin_Page adm = new Admin_Page();
                adm.ShowDialog();
                


            }
            else
            {
                MessageBox.Show("Enter Your Data First");
            }
        }

        private void AddRegisterData()
        {
            /* Register re = new Register();
             re.User_Name = txtUserName.Text;
             re.Password = txtPassword.Text;
             re.Email = txtEmail.Text;
             re.Phone = txtPhoneNumber.Text;
             db.Registers.Add(re);*/
            db.Registers.Add(new Register { UserName = txtUserName.Text, Password = txtPassword.Text, Email = txtEmail.Text, Phone = txtPhoneNumber.Text });
            db.SaveChanges();
            MessageBox.Show("You Registered Succesfully,Congrats");
            

        }

        private void ClearRegisterData()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
