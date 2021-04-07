using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_Aaah_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                input.Add(line);
                Console.WriteLine(GoToDoctor(input));
            }
        }
        public static string GoToDoctor(List<string> listOfAahs)
        {
            if (listOfAahs[listOfAahs.Count() - 1].Count(a => a == 'a') < listOfAahs[listOfAahs.Count()].Count(a => a == 'a'))
            {
                return "no";
            }
            else
            {
                return "go";
            }
        }
    }
}
