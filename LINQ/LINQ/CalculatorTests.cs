using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Calculator
    {

        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Find_max(IEnumerable<int> collection)
        {
            int max = collection.Max();
            return max;
        }
        public IEnumerable<int> Square_even_elements(IEnumerable<int> collection)
        {
            var new_collection = collection
                .Where(el => (el % 2 == 0))
                .Select(el => Multiply(el, el));
            return new_collection;
        }
    }
}
