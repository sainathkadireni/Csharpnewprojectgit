using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnewproject.day3.ex
{
    class Box
    {
        public int length;
        public int width;

        public double CalculateArea()
        {
            double area = length * width;
            Console.WriteLine("Area =" + area);
            return area;
        }
    }
}
