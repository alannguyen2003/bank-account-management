using Services.Models;
using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2_2
{
    public partial class login : Form
    {
        UserServices UserServices = new UserServices();

        public login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            User user = UserServices.GetAll().FirstOrDefault(user => user.UserName == username && user.Password == password);
            if (user != null)
            {
                //Đăng nhập thành công
                //MessageBox.Show(user.UserName + " " + user.Password, "Thong bao", MessageBoxButtons.OK);
                this.Hide();
                Form frManagement = new Management1(user);
                frManagement.ShowDialog();
            }
            else
            {
                //Đăng nhập thất bại
                MessageBox.Show("Wrong username or password!!", "Thong bao", MessageBoxButtons.OK);
            }
        }
    }
}
