using System;
using System.Runtime.CompilerServices;

namespace VMakarov.SalaryDev.Domain
{
    public class TimeLogger
    {
        public static double FillTime()
        {
            Console.WriteLine("Please indicate your hours worked per month: ");
            try
            {
                double worktime = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                return worktime;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return 0;
            }
        }
    }
}