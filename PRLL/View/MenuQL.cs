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
    public partial class MenuQL : Form
    {
        public MenuQL()
        {
            InitializeComponent();
        }

        private void MenuQL_Load(object sender, EventArgs e)
        {
            label1.Text = "User : " + userName;
        }

        private void btn_QLDoiTra_Click(object sender, EventArgs e)
        {
            QLDoiHang qlDoiTra = new QLDoiHang (userName); 
            qlDoiTra.ShowDialog();
        }
    }
}
