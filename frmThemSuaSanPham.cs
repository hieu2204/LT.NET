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
    public partial class frmThemSuaSanPham : Form
    {
        private List<SanPham> lst;
        public SanPham currentSanPham { get; set; }
        public frmThemSuaSanPham(List<SanPham> ProductList, SanPham sp)
        {
            InitializeComponent();
            lst = ProductList;
            currentSanPham = sp;
            if(currentSanPham != null)
            {
                txtMaSP.Text = currentSanPham.maSP.ToString();
                txtTenSP.Text = currentSanPham.tenSP.ToString();
                cbLoaiSP.Text = currentSanPham.loaiSP.ToString();
                txtSoLuong.Text = currentSanPham.soLuong.ToString();
                txtGiaTien.Text = currentSanPham.giaTien.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmThemSuaSanPham_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int masp = int.Parse(txtMaSP.Text);
                string tensp = txtTenSP.Text;
                string loaisp = cbLoaiSP.Text;
                string soluong = txtSoLuong.Text;
                string giatien = txtGiaTien.Text;

                if (currentSanPham != null)
                {
                    // Cập nhật lại sản phẩm hiện tại nếu đang sửa
                    currentSanPham.tenSP = tensp;
                    currentSanPham.loaiSP = loaisp;
                    currentSanPham.soLuong = soluong;
                    currentSanPham.giaTien = giatien;
                }
                else
                {
                    // Thêm mới sản phẩm nếu currentSanPham là null
                    SanPham sp = new SanPham(masp, tensp, loaisp, soluong, giatien);
                    lst.Add(sp);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm." + ex.Message);
            }
        }
    }
}
