using PRLL.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class HoaDon : Form
    {
        public bool isExit = true;
    
        private bool isExitApplication = false;
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }

        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           
            try
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.Yes)
                {
                    isExitApplication = true;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Đăng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
