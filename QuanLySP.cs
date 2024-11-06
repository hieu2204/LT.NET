using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySP
{
    public partial class QuanLySP : Form
    {
        public QuanLySP()
        {
            InitializeComponent();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            QuanLySanPham quanLySanPham = new QuanLySanPham();
            quanLySanPham.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
