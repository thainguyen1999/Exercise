using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.QuanLyTienDien
{
    public abstract class KhachHang
    {
        public int makH { get; set; }
        public string tenKH { get; set; }
        public string ngayLap { get; set; }
        public int soluong { get; set; }

        public KhachHang(int MaKH, string TenKH, string NgayLap, int Soluong)
        {
            makH = MaKH;
            tenKH = TenKH;
            ngayLap = NgayLap;
            soluong = Soluong;

        }
    }
}
