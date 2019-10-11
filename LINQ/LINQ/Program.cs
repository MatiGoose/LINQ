using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 1, 2, 3, 4, 5 };
            MyIEnumerable<int> ml = new MyList<int>(mass);
            var iterator = ml.Where(x => (x / 2) > 1).Select(x => x * x);  
            
            foreach(var el in iterator)
            {
                Console.WriteLine(iterator);
            }
            if(iterator.Any(x => (x % 2) == 0))
            {
                Console.WriteLine("Any element is even");
            }
            var newIteratro = iterator.Select(x => x * 2);
            if (newIteratro.All(x => (x % 2) == 0))
            {
                Console.WriteLine("Even elements");
            }
            Console.ReadLine();
        }
    }

}

