using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private List<SanPham> danhsachsanpham = new List<SanPham>();

        public Form1()
        {
            InitializeComponent();
        //    tb1.AllowUserToAddRows = false;   // Disable auto-adding new rows
            tb1.CellMouseClick += selectedRow;  // Event for selecting a row
            btnXoa.Click += btnXoa_Click;       // Gắn sự kiện nhấn vào nút "Xóa"
                                                // Định nghĩa các cột cho DataGridView (chỉ nếu chưa được định nghĩa)
            tb1.ColumnCount = 7;
            tb1.Columns[0].Name = "Mã SP";
            tb1.Columns[1].Name = "Tên SP";
            tb1.Columns[2].Name = "Đơn Giá";
            tb1.Columns[3].Name = "Hình Ảnh";
            tb1.Columns[4].Name = "Mô Tả Ngắn";
            tb1.Columns[5].Name = "Mô Tả Chi Tiết";
            tb1.Columns[6].Name = "Loại SP";

            // Khởi tạo DataGridView với dữ liệu hiện tại
            UpdateGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();  // Initialize DataGridView with current data
        }

        // Nút Thêm sản phẩm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string Ma = textBox1.Text;
            string Ten = textBox2.Text;
            string Gia = textBox3.Text;
            string hinhanh = textBox4.Text;
            string motangan = textBox5.Text;
            string motachitiet = textBox6.Text;
            string loaisp = comboBox1.Text;

            if (string.IsNullOrEmpty(Ma) || string.IsNullOrEmpty(Ten) || string.IsNullOrEmpty(Gia) ||
                string.IsNullOrEmpty(hinhanh) || string.IsNullOrEmpty(motangan) || string.IsNullOrEmpty(motachitiet))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                SanPham sanPham = new SanPham
                {
                    MaSP = Ma,
                    TenSP = Ten,
                    DonGia = Gia,
                    HinhAnh = hinhanh,
                    MoTaNgan = motangan,
                    MoTaChiTiet = motachitiet,
                    LoaiSP = loaisp
                };

                danhsachsanpham.Add(sanPham);
                UpdateGrid();
                SelectLastRow();  // Select last row after adding
                ResetFields();
            }
        }

        // Nút Sửa sản phẩm
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tb1.SelectedRows.Count > 0 && tb1.SelectedRows[0].Index >= 0)
            {
                int selectedIndex = tb1.SelectedRows[0].Index;

                // Get the selected product
                SanPham selectedSanPham = danhsachsanpham[selectedIndex];

                // Update product information
                selectedSanPham.MaSP = textBox1.Text;
                selectedSanPham.TenSP = textBox2.Text;
                selectedSanPham.DonGia = textBox3.Text;
                selectedSanPham.HinhAnh = textBox4.Text;
                selectedSanPham.MoTaNgan = textBox5.Text;
                selectedSanPham.MoTaChiTiet = textBox6.Text;
                selectedSanPham.LoaiSP = comboBox1.Text;

                UpdateGrid();
                MessageBox.Show("Sản phẩm đã được cập nhật.");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ để sửa.");
            }
        }

        // Nút Xóa sản phẩm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tb1.SelectedRows.Count > 0 && tb1.SelectedRows[0].Index >= 0)
            {
                int selectedIndex = tb1.SelectedRows[0].Index;

                // Remove the selected product from the list
                danhsachsanpham.RemoveAt(selectedIndex);

                // Update the DataGridView to reflect the changes
                UpdateGrid();

                MessageBox.Show("Sản phẩm đã được xóa.");

                // Optionally reset the input fields after deletion
                ResetFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ để xóa.");
            }
        }


        // Sự kiện khi chọn hàng trong DataGridView
        private void selectedRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhsachsanpham.Count)
            {
                SanPham selectedSanPham = danhsachsanpham[e.RowIndex];

                // Populate text boxes
                textBox1.Text = selectedSanPham.MaSP;
                textBox2.Text = selectedSanPham.TenSP;
                textBox3.Text = selectedSanPham.DonGia;
                textBox4.Text = selectedSanPham.HinhAnh;
                textBox5.Text = selectedSanPham.MoTaNgan;
                textBox6.Text = selectedSanPham.MoTaChiTiet;
                comboBox1.Text = selectedSanPham.LoaiSP;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng hợp lệ.");
            }
        }

        // Nút Đặt lại các ô nhập liệu
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        // Hàm đặt lại các ô nhập liệu
        private void ResetFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
        }

        // Cập nhật DataGridView bằng cách thêm các hàng từ danh sách sản phẩm
        private void UpdateGrid()
        {
            tb1.Rows.Clear();  // Clear existing rows

            foreach (SanPham sp in danhsachsanpham)
            {
                tb1.Rows.Add(sp.MaSP, sp.TenSP, sp.DonGia, sp.HinhAnh, sp.MoTaNgan, sp.MoTaChiTiet, sp.LoaiSP);
            }
        }

        // Hàm chọn hàng cuối cùng sau khi thêm sản phẩm
        private void SelectLastRow()
        {
            if (tb1.Rows.Count > 0)
            {
                tb1.ClearSelection();  // Clear current selection
                tb1.Rows[tb1.Rows.Count - 1].Selected = true;  // Select last row
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }
    }
}
