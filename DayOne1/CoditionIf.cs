using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnewproject.DayOne1
{
    internal class CoditionIf
    {
        static void Main()
        {
            int X = 20;
            int Y= 20;

            if (X < Y)
            {
                Console.WriteLine("x is less then y");
            }
            if(X > Y)
            {
                Console.WriteLine("x is greter then y");
            }
            if(X == Y)
            {
                Console.WriteLine("x is equal to y");
            }
        }
    }
}
