using System;

namespace P01GroupsOfEqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int resultSum = 0;
            if (n1 == n2 + n3 + n4)
            {
                resultSum = n1;
            } 
            else if (n2 == n1 + n3 + n4)
            {
                resultSum = n2;
            }
            else if (n3 == n1 + n2 + n4)
            {
                resultSum = n3;
            }
            else if (n4 == n1 + n2 + n3)
            {
                resultSum = n4;
            }
            else if (n1 + n2 == n3 + n4)
            {
                resultSum = n1 + n2;
            }
            else if (n1 + n3 == n2 + n4)
            {
                resultSum = n1 + n3;
            }
            else if (n1 + n4 == n2 + n3)
            {
                resultSum = n1 + n4;
            }
            else if (n1 + n2 + n3 + n4 == 0)
            {
                resultSum = 0;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine("Yes");
            Console.WriteLine(resultSum);
            //main ends here
        }
    }
}
