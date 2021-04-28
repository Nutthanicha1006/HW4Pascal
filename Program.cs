using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input, X = 0;

            Console.Write("");
            Input = int.Parse(Console.ReadLine());

            while (Input < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");

                Console.Write("");
                Input = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= Input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        X = 1;
                    }
                    else if (j == 1)
                    {
                        X = i;
                    }
                    else if (i - j == 1)
                    {
                        X = i;
                    }
                    else
                    {
                        X = X * ((i - j) + 1) / j;
                    }
                    Console.Write("{0} ", X);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
