using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.PracticalEx.Exercise_2
{
    public class Program
    {
       static void Main(string[] args)
        {
            Animal a = new Lion(250, "Lion");
            a.Show();
            a = new Tiger(200, "Tiger");
            a.Show();
        }
    }
}
