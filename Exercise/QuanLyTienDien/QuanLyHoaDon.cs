using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.QuanLyTienDien
{
    internal class QuanLyHoaDon
    {
        public QuanLyHoaDon() { }

        public static void Main(string[] args)
        {
            KhachHangVN KHVN = new KhachHangVN(12, "nguyen", "02/02/2022", 200, "Sinh Hoat");
            Console.WriteLine(KHVN.TinhTien());
        }
    }
}
