using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> input = {
            // "at",
            //"ordeals",
            // "abcdefghijklmnopqrstuvwxyz",
            // "abcdefghijklmabcdefghijklm",
            // "abcdABCDabcd"};
            List<string> inputs = new List<string>();
            inputs.Add("ordeals");
            inputs.Add("ordeals");
            String str = "fvvfhvgv";

            Console.Write(countDistinctPermutations("abcdefghijklmnopqrstuvwxyz"));
            Console.ReadLine();
        }
        static int MAX_CHAR = 26;

        // Utility function to find factorial of n. 
        static ulong factorial(ulong n)
        {
            ulong fact = 1;
            for (ulong i = 2; i <= n; i++)
                fact = fact * i;

            return fact;
        }

        // Returns count of distinct permutations 
        // of str. 
        static ulong countDistinctPermutations(String str)
        {
            ulong length = (ulong)str.Length;

            int[] freq = new int[MAX_CHAR];

            // finding frequency of all the lower case 
            // alphabet and storing them in array of 
            // integer 
            for (int i = 0; i < (int)length; i++)
                if (str[i] >= 'a')
                {
                    freq[str[i] - 'a']++;
                }
                    
                    

            // finding factorial of number of appearances 
            // and multiplying them since they are 
            // repeating alphabets 
            ulong fact = 1;
            for (ulong i = 0; i < (ulong)MAX_CHAR; i++)
                fact = fact * factorial((ulong)freq[i]);

            // finding factorial of size of string and 
            // dividing it by factorial found after 
            // multiplying 
            
            return factorial(length) / fact;
        }
    

    public static int CountStringAnagrams(string input)
        {
            List<string> words = new List<string>();

            for (int i = input.Length-1; i > 0; i--)
            {
                for(int j = 0; j < input.Length; j++)
                { 
                    words.Add(LetterToLast(input, i,j));
                    Console.WriteLine(words[j]);
                }
            }
            
            return words.Count;
        }

        static string LetterToLast(string input, int index, int length)
        {
            string output = input;
            output += output.Substring(index, length);
            output = output.Remove(index, length);
            return output;
        }

    }
}
