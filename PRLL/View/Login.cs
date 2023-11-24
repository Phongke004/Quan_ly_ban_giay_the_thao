using BUS.Services;
using DAL.Context;
using PRL.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using HoaDon = PRL.View.HoaDon;

namespace PRLL.View
{
    public partial class Login : Form
    {
        private NhanVienServices _service;
        private string user, pass;
        private bool isExitApplication = false;
        public Login()
        {
            _service = new NhanVienServices();
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            MenuQL menuQl = new MenuQL(userName);
            menuQl.ShowDialog();

        }

        }
        private bool checkAccount()
        {
            bool rs = check();
            var checkAD = _service.CheckExistsNV(user, pass);
            if (!checkAD)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                return false;
            }
            else

            {
                return true;
            }
        }
        private bool check()
        {
            user = txtUser.Text.Trim();
            pass = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return false;
            }
            return true;
        }
        private bool checkText()
        {
            var user = txtUser.Text.Trim();
            var pass = txtPassword.Text.Trim();
            return string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass);
        }
        private void Hd_logOut(object? sender, EventArgs e)
        {
            (sender as HoaDon).isExit = false; //Không tắt chương trình chỉ đăng xuất
            (sender as HoaDon).Close();
            this.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
