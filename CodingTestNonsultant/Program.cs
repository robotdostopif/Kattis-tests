using System;

namespace CodingTestNonsultant
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[3 * 2];
            input[0] = "ATCCGCTTAGAGGGATT";
            input[1] = "GTCCGTTTAGAAGGTTT";
            input[2] = "abcdefghijklmnopqrstuvwxyz";
            input[3] = "bcdefghijklmnopqrstuvwxyza";
            input[4] = "abcdefghijklmnopqrstuvwxyz0123456789";
            input[5] = "abcdefghijklmnopqrstuvwxyz0123456789";

            PrintDifferences(input);
            Console.ReadKey();
        }

        static void PrintDifferences(string[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    Console.WriteLine(input[i]);
                    Console.WriteLine(input[i + 1]);
                    for (int j = 0; j < input[i].Length; j++)
                    {
                        if (input[i][j] == input[i + 1][j])
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
