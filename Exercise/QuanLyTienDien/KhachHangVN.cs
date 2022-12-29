using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.QuanLyTienDien
{
    public class KhachHangVN : KhachHang
    {
       public string doiTuongKH { get; set; }
        public KhachHangVN(int MaKH, string TenKH, string NgayLap, int Soluong, string DoiTuongKH)
            : base(MaKH, TenKH, NgayLap, Soluong)
        {
            doiTuongKH = DoiTuongKH;
        }
        public double TinhTien()
        {
            if (soluong < 50)
            {
                return soluong * 1000;
            }
            else if (soluong < 100)
            {
                return (soluong - 50) * 1200 + 50 * 1000;
            }
            else if (soluong < 200)
            {
                return (soluong - 100) * 1500 + 50 * 1200 + 50 * 1000;
            }
            else
            {
                return (soluong - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
            }
        }
    }
}
