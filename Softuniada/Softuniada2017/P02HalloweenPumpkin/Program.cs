using System;

namespace P02HalloweenPumpkin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pictureWidth = n * 2 + 1;

            //top part:
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), "_/_");
            Console.WriteLine("/{0}^,^{0}\\", new string('.', n - 2));
            //middle part:
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string('.', pictureWidth - 2));
            }
            //bottom part:
            Console.WriteLine("\\{0}\\_/{0}/", new string('.', (pictureWidth - 5) / 2));

            //main ends here
        }
    }
}
