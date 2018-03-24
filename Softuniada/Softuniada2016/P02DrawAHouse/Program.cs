using System;
using System.Text;

namespace P02DrawAHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int pictureWidth = 2 * n - 1;

            Console.WriteLine("{0}*{0}", new string('.', n - 1));

            for (int row = 1; row <= n - 1; row++)
            {
                if (row != n - 1)
                {
                    int numberOfDots = (pictureWidth - 2 - (2 * row - 1)) / 2;
                    Console.WriteLine("{0}*{1}*{0}", new string('.', numberOfDots), new string(' ', row * 2 - 1));
                }
                else
                {
                    Console.WriteLine(newString("* ", n));
                }
            }

            for (int row = 0; row < n; row++)
            {
                if (row != 0 && row != n - 1)
                {
                    Console.WriteLine("|{0}|", new string(' ', pictureWidth - 2));
                }
                else
                {
                    Console.WriteLine("+{0}+", new string('-', pictureWidth - 2));
                }
            }

            //main ends here
        }

        static string newString(string str, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

        //class ends here
    }
}
