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
    public partial class QuanLySanPham : Form
    {
        private List<SanPham> ProductList = new List<SanPham>();
        private SanPham selectedSanPham;
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemSuaSanPham frm = new frmThemSuaSanPham(ProductList, selectedSanPham);
            frm.ShowDialog();
            UpdateSanPham(ProductList);
        }
        public void UpdateSanPham(List<SanPham> ProductList)
        {
            dataGridViewSanPham.DataSource = null;
            dataGridViewSanPham.DataSource = ProductList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSanPham != null)
            {
                // Mở form chỉnh sửa với thông tin sản phẩm đã chọn
                frmThemSuaSanPham frm = new frmThemSuaSanPham(ProductList, selectedSanPham);
                frm.ShowDialog();

                // Sau khi sửa xong, cập nhật lại DataGridView để hiển thị thông tin mới
                UpdateSanPham(ProductList);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
            }
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Kiểm tra nếu có hàng được chọn
            {
                // Lấy hàng đã chọn
                DataGridViewRow row = dataGridViewSanPham.Rows[e.RowIndex];

                // Lấy thông tin từ hàng và tạo đối tượng SanPham
                selectedSanPham = new SanPham(
                    Convert.ToInt32(row.Cells["MaSP"].Value), // Chuyển MaSP sang kiểu int
                    row.Cells["TenSP"].Value.ToString(),
                    row.Cells["LoaiSP"].Value.ToString(),
                    row.Cells["SoLuong"].Value.ToString(),
                    row.Cells["GiaTien"].Value.ToString()
                );

                // Debug thông báo kiểm tra
                MessageBox.Show("Đã chọn sản phẩm: " + selectedSanPham.tenSP);
            }
        }
    }
}
