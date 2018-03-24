using System;
using System.Text;

namespace P03DuplicatedLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            int count = 0;

            while (Salvation(sb))
            {
                count++;
            }

            if (sb.Length > 0)
            {
                Console.WriteLine(sb);
            } 
            else
            {
                Console.WriteLine("Empty String");
            }

            Console.WriteLine(count + " operations");
            //main ends here
        }

        static bool Salvation(StringBuilder sb)
        {
            bool result = false;
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == sb[i + 1])
                {
                    result = true;
                    sb.Remove(i, 2);
                    break;
                }
            }
            return result;

        }
        //class ends here
    }
}
