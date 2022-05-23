using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class EmpWage
    {
        /// <summary>
        /// This program is used to check whether employee is present or absent
        /// </summary>
        public static void empcheck()
        {

            int isPresent = 1;
            Random r = new Random();
            int check = r.Next(2);

            if (check == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }

    }
}
