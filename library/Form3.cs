using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.library;
            this.Icon = Properties.Resources.Icon2;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U3TLO97\SQL2017TEST;Initial Catalog=Library;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Register where UserName= '" + txtUserName.Text + "' and Password= '" + txtPassword.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() =="1")
            {
                MessageBox.Show("Welcome" +" "+ txtUserName.Text);
                this.Hide();
                Admin_Page adm = new Admin_Page();
                adm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your UserName Or Password Is Incorrect");
                ClearLogInData();
            }
            }
        private void ClearLogInData()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            
        }

    }
    }

