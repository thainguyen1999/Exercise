using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.QuanLyTienDien
{
    public  class KhachHangNuocNgoai : KhachHang
    {
        public string quocTich;
        public KhachHangNuocNgoai(int MaKH, string TenKH, string NgayLap, int Soluong,string quocTich) 
            : base(MaKH, TenKH,NgayLap,Soluong)
        {
            this.quocTich = quocTich;
        }
        public double TinhTien()
        {
            return soluong* 2000;
        }
    }
}
