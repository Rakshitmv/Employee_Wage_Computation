using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-*-----Welcome to Employee Wage Computation Program-----*-*-*-");
            WageComputation wageComputation = new WageComputation();
            wageComputation.Data();
            Console.ReadLine();
        }
    }
}
