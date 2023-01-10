using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.house.cm
{
    public class House: IHouse
    {
        private string SoNha;
        private string DiaChi;
        private string LoaiNha;
        public House() 
        {
            SoNha = "";
            DiaChi = "";
            LoaiNha = "";
        }
        public House(string soNha, string diaChi, string loaiNha)
        {
            SoNha = soNha;
            DiaChi = diaChi;
            LoaiNha = loaiNha;
        }
        public string soNha
        {
            get { return SoNha; }
            set { SoNha= value;}
        }
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi= value;}
        }
        public string loaiNha
        {
            get { return LoaiNha; }
            set
            {
                LoaiNha = value;
            }
        }
        public void input() {
            Console.WriteLine("Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhập loại nhà: ");
            LoaiNha = Console.ReadLine();
        }
        public void display() {
            Console.WriteLine("Số nhà: " + SoNha);
            Console.WriteLine("Địa chỉ: " + DiaChi);
            Console.WriteLine("Loại nhà: " + LoaiNha);
        }
        
    }
}
