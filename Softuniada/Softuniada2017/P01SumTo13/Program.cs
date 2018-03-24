using System;
using System.Linq;

namespace P01SumTo13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int x = numbers[0];
            int y = numbers[1];
            int z = numbers[2];

            if (x + y + z == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x * -1 + y + z == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x + y * -1 + z == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x + y + z * -1 == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x * -1 + y * -1 + z == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x * -1 + y + z * -1 == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x + y * -1 + z * -1 == 13)
            {
                Console.WriteLine("Yes");
            }
            else if (x * -1 + y * -1 + z * -1 == 13)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //main ends here
        }
    }
}
