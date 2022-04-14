﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpComputation
{
    internal class Uc6_Daywisewage
    {
       
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Day = 20;
        public const int Max_Hours_In_Month = 100;

        public static void EmpDaywisewage()
        {
            Console.WriteLine();
            Console.WriteLine("Uc6 Begin here ****************");
            int totalWorkingDays = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs<=Max_Hours_In_Month && totalWorkingDays< Num_Of_Working_Day)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                  Console.WriteLine("Days : {0} Emp Hours : {1}" , totalWorkingDays ,empHrs);
            }
            int totalEmpWages = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage: " + totalEmpWages);
        }

    }
}
