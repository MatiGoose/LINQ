using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> myARR = new List<int>
            {
                1,
                5,
                4,
                3,
                6,
                3,
                2
            };

            var selectedNumbers = myARR.Where(el => ((el % 2) == 0)).OrderBy(el => el);
            foreach(int el in selectedNumbers)
            {
                Console.WriteLine(el);
            }
            myARR.Add(5);
            myARR.Add(2);
            foreach (int el in selectedNumbers)
            {
                Console.WriteLine(el);
            }
        }
    }
}
