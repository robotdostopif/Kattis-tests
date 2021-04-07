using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Kattistest
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                BigInteger counter = CountDistinctPermutations(line);
                Console.WriteLine(counter.ToString());
            }


        }

        static int Array_Length = 52;
        static BigInteger Factorial(BigInteger n)
        {
            BigInteger fact = 1;
            for (ulong i = 2; i <= n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        static int[] CountDuplicatedChars(string input)
        {
            int length = input.Length;

            int[] freq = new int[Array_Length];

            for (int i = 0; i < (int)length; i++)
            {
                if (input[i] >= 'a')
                {
                    freq[input[i] - 'a']++;
                }
                else if (input[i] >= 'A')
                {
                    freq[input[i] - 'A' + (Array_Length / 2)]++;
                }
            }
            return freq;
        }

        static BigInteger CountDistinctPermutations(string input)
        {
            int[] letterArray = CountDuplicatedChars(input);

            BigInteger fact = 1;
            for (ulong i = 0; i < (ulong)Array_Length; i++)
            {
                fact = fact * Factorial((BigInteger)letterArray[i]);
            }

            return Factorial((BigInteger)input.Length) / fact;
        }
    }
}
