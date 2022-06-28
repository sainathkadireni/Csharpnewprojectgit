using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnewproject.Day2.Excercises
{
    class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();

            alex.salary = 10000;
            alex.bonus = 20000;
            alex.CalculateTotalPay();

            lynda.salary = 10000;
            lynda.bonus = 30000;
            lynda.CalculateTotalPay();
        }
    }
}
