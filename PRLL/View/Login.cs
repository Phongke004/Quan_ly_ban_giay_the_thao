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

namespace PRLL.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            MenuQL menuQl = new MenuQL(userName);
            menuQl.ShowDialog();

        }

        private void Hd_logOut(object? sender, EventArgs e)
        {
            (sender as HoaDon).isExit = false; //Không tắt chương trình chỉ đăng xuất
            (sender as HoaDon).Close();
            this.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
