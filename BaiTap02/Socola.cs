using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class Socola : SanPham
    {
        private double loinhuan;
        //phuong thuc khoi tao
        public Socola() { }
        public Socola(string tensanpham,double giamua,double loinhuan):base(tensanpham,giamua)
        {
            this.loinhuan = loinhuan;
        }
        //property
        public double LoiNhuan
        {
            set { loinhuan = value; }
            get { return loinhuan; } 
        }
        //tinh loi nhuan
        public double TinhLoiNhuan()
        {
            return GiaMua*0.2;
        }
        //phuong thuc ghi de
        //tinh gia ban
        public override double TinhGiaBan()
        {
            return GiaMua + TinhLoiNhuan();
        }
        public override void Nhap()
        {
            Console.WriteLine(" -- Nhap thong tin Socola : ");
            Console.Write("Nhap ten san pham : ");
            string tensp =Console.ReadLine();
            Console.Write("Nhap gia mua : ");
            double giamua=double.Parse(Console.ReadLine());
        }
    }
}
