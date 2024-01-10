using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class QuanLySanPham
    {
        private string ten;
        private QuanLySanPham[] danhSachSP;
        private int n;

        public QuanLySanPham()
        {
            danhSachSP = new QuanLySanPham[100];
            n = 0;
        }
        public QuanLySanPham(int sophantu)
        {
            danhSachSP = new QuanLySanPham[sophantu];
            n = 0;
        }
    }
}
