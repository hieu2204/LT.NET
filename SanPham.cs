using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySP
{
    public class SanPham
    {
        private int MaSP;
        private string TenSP;
        private string LoaiSP;
        private string GiaTien;
        private string SoLuong;
        public SanPham()
        {
        }
        public SanPham(int maSP, string tenSP, string loaiSP, string giaTien, string soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            LoaiSP = loaiSP;
            GiaTien = giaTien;
            SoLuong = soLuong;
        }
        public int maSP
        {
            get  { return MaSP; }
            set { MaSP = value; }
        }
        public string tenSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        public string loaiSP
        {
            get { return LoaiSP; }
            set { LoaiSP = value; }
        }
        public string soLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public string giaTien
        {
            get { return GiaTien; }
            set { GiaTien = value; }
        }
    }
}
