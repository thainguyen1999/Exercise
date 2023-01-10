using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.house.hanoi
{
    internal class ManagerHouse
    {
        private HaNoiIHouse[] houses;
        private int n;

        public ManagerHouse()
        {
            houses=new HaNoiIHouse[2];
        }
        // Phương thức nhập thông tin n ngôi nhà ở Hà Nội
        public void input()
        {
            Console.WriteLine("Nhập số lượng ngôi nhà: ");
            n = int.Parse(Console.ReadLine());
            houses = new HaNoiIHouse[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin ngôi nhà thứ " + (i + 1) + ":");
                houses[i] = new HaNoiIHouse();
                houses[i].input();
            }
        }
        // Phương thức hiển thị thông tin của n ngôi nhà đó
        public void display()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin ngôi nhà thứ " + (i + 1) + ":");
                houses[i].display();
            }
        }
        // Phương thức sắp xếp theo trường địa chỉ và hiển thị thông tin sau khi sắp xếp
        public void sort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (String.Compare(houses[i].diaChi, houses[j].diaChi) > 0)
                    {
                        HaNoiIHouse temp = houses[i];
                        houses[i] = houses[j];
                        houses[j] = temp;
                    }
                }
            }
            Console.WriteLine("Thông tin ngôi nhà sau khi sắp xếp theo trường địa chỉ:");
            display();
        }
        // Phương thức tìm kiếm nhà theo địa chỉ nhập vào
        public void search()
        {
            Console.WriteLine("Nhập địa chỉ cần tìm: ");
            string address = Console.ReadLine();
            int found = 0;
            for (int i = 0; i < n; i++)
            {
                if (houses[i].diaChi == address)
                {
                    Console.WriteLine("Thông tin ngôi nhà tìm được:");
                    houses[i].display();
                    found = 1;
                    break;
                }
            }
            if (found == 0)
            {
                Console.WriteLine("Không tìm thấy ngôi nhà có địa chỉ như trên.");
            }
        }
    }
}
