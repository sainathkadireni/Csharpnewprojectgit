using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnewproject.DayOne1
{
    internal class Array
    {
        static void Main()
        {
            int[] a = { 10, 20, 30, 40, 50 };
          
            foreach(int tempvar in a)
            {
                Console.WriteLine(tempvar);
            }
            int[] x = new int[6];
            x[0] = 1;
            x[1] = 22;
            foreach(int z in x)
            {
                Console.WriteLine(z);
            }
            
        }
    }
}
