using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class NuocUong:SanPham
    {
        private double loinhuan;
        private double chiphigiulanh;
        //phuong thuc khoi tao
        public NuocUong() { }
        public NuocUong(string tensanpham,double giamua,double loinhuan, double chiphigiulanh):base(tensanpham,giamua)
        {
            this.loinhuan = loinhuan;
            this.chiphigiulanh = chiphigiulanh;
        }
        //property
        public double LoiNhuan
        {
            set { loinhuan = value; }
            get { return loinhuan; }
        }
        public double ChiPhiGiuLanh
        {
            set { chiphigiulanh = value; }
            get { return chiphigiulanh; }
        }
        //tinh loi nhuan
        public double TinhLoiNhuan()
        {
            return GiaMua * 0.15;
        }
        //tinh chi phi giu lanh
        public double TinhChiPhiGiuLanh()
        {
            return GiaMua * 0.1;
        }
        //phuong thuc ghi de
        public override double TinhGiaBan()
        {
            return GiaMua + TinhLoiNhuan() + TinhChiPhiGiuLanh();
        }
        public override void Nhap()
        {
            Console.WriteLine(" -- Nhap thong tin Socola : ");
            Console.Write("Nhap ten san pham : ");
            string tensp = Console.ReadLine();
            Console.Write("Nhap gia mua : ");
            double giamua = double.Parse(Console.ReadLine());
        }
    }
}
