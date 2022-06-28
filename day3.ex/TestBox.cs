using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnewproject.day3.ex
{
    internal class TestBox
    {
        static void Main()
        {
            Box ups, fedEx;
            ups = new Box();
            fedEx = new Box();
            ups.length = 10;
            ups.width = 2;
            double total = ups.CalculateArea();
            fedEx.length = 15;
            fedEx.width = 15;
            total += fedEx.CalculateArea();
            Console.WriteLine("Total Area =" + total);

        }
    }
}      

