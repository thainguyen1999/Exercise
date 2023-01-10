using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.PracticalEx.Geometry
{
    public class GeometryExam
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.Input();
            cylinder.Process(cylinder.Radius, cylinder.Height);
            Console.WriteLine("Cylinder Characteristics: ");
            Console.WriteLine(cylinder.Result());
        }
    }
}
