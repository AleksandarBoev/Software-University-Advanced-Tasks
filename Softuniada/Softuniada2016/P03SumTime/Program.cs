using System;
using System.Linq;

namespace P03SumTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            int[] times1 = input1.Split(':').Where(s => s != "").Select(n => int.Parse(n)).ToArray();
            int days1 = 0;
            int hours1 = 0;
            int minutes1 = 0;
            if (times1.Length == 3)
            {
                days1 = times1[0];
                hours1 = times1[1];
                minutes1 = times1[2];
            }
            else
            {
                hours1 = times1[0];
                minutes1 = times1[1];
            }

            string input2 = Console.ReadLine();
            int[] times2 = input2.Split(':').Where(s => s != "").Select(n => int.Parse(n)).ToArray();
            int days2 = 0;
            int hours2 = 0;
            int minutes2 = 0;
            if (times2.Length == 3)
            {
                days2 = times2[0];
                hours2 = times2[1];
                minutes2 = times2[2];
            }
            else
            {
                hours2 = times2[0];
                minutes2 = times2[1];
            }

            int allMinutes = (minutes1 + minutes2) % 60;
            int allHours = ((hours1 + hours2) + (minutes1 + minutes2) / 60) % 24;
            int alldays = days1 + days2 + (((hours1 + hours2) + (minutes1 + minutes2) / 60) / 24);

            if (alldays > 0)
            {
                Console.WriteLine($"{alldays}::{allHours}:{allMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{allHours}:{allMinutes:D2}");
            }
            //main ends here
        }
    }
}
