﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnewproject.DayOne1
{
    internal class Switchcase
    { 
        static void Main()
        {
            string j = "Two";

            switch (j)  
        {
            case "Zero":
                Console.WriteLine("value is 0");
                break;
            case "One":
                Console.WriteLine("value is 1");
                break;
            case "Two":
                Console.WriteLine("value is 2");
                break;
            case "Three":
                Console.WriteLine("value is 3");
                break;
            
            default:
                Console.WriteLine("value is not found");
                break;

        }
        }
    }
}
