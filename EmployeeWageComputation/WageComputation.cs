using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        public void CalculateEmployeeWage()
        {
            const int PART_TIME = 0, FULL_TIME = 1, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4, WORKING_DAYS = 20;
            int monthlyWage = 0;
            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS; i++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case PART_TIME:
                        monthlyWage += WAGE_PER_HOUR * PART_TIME_HOUR;
                        break;
                    case FULL_TIME:
                        monthlyWage += WAGE_PER_HOUR * FULL_DAY_HOUR;
                        break;
                    default:
                        monthlyWage += 0;
                        break;
                }
            }
            Console.WriteLine("The Monthly Wage Of the Employee is :{0}", monthlyWage);



        }
    }
}
