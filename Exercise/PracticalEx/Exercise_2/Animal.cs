using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.PracticalEx.Exercise_2
{
    public class Animal
    {
        public double weight;
        public string name;
        public Animal(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}
