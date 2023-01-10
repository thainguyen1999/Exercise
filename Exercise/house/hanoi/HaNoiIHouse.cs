using Exercise.house.cm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.house.hanoi
{
    public class HaNoiIHouse : House
    {
        private string tenQuan;
        public HaNoiIHouse() {
            tenQuan = "";
        }
        public HaNoiIHouse(string SoNha, string DiaChi, string LoaiNha, string tenQuan)
            : base(SoNha, DiaChi, LoaiNha)
        {
            this.tenQuan = tenQuan;
        }
        public string TenQuan
        {
            get { return tenQuan; }
            set { tenQuan = value; }
        }
        public  void input()
        {
            base.input();
            Console.WriteLine("Nhập tên quận: ");
            tenQuan = Console.ReadLine();
        }
         public  void display()
        {
            base.display();
            Console.WriteLine("Tên quận: " + tenQuan);
        }
    }
}
