using System;
using System.Collections.Generic;

namespace LINQ
{
    public static partial class IterExtension
    {
        public static Tsource[] ToArray<Tsource>(this MyIEnumerable<Tsource> source)
        {
            Tsource[] array = new Tsource[source.Length()];
            int i = 0;
            foreach(Tsource element in source)
            {
                array[i] = element;
                i++;
            }
            return array;
        }

        public static int Length<Tsource>(this MyIEnumerable<Tsource> source)
        {            
            int i = 0;
            foreach (Tsource element in source)
            {                
                i++;
            }
            return i;
        }
        public static MyIEnumerable<Tsource> Where<Tsource>(this MyIEnumerable<Tsource> source, Func<Tsource, bool> condition)
        {
            
            var result = new WhereEnumerable<Tsource>(source, condition);
            return result;
        }

        public static MyIEnumerable<Tsource> Select<Tsource>(this MyIEnumerable<Tsource> source, Func<Tsource, Tsource> function)
        {           
            var result = new SelectEnumerable<Tsource>(source, function);
            return result;
        }

        public static bool All<Tsource>(this MyIEnumerable<Tsource> source, Func<Tsource, bool> condition)
        {
            foreach (Tsource element in source)
            {
                if (!condition(element))
                    return false;
            }
            return true;
        }

        public static bool Any<Tsource>(this MyIEnumerable<Tsource> source, Func<Tsource, bool> condition)
        {
            foreach (Tsource element in source)
            {
                if (condition(element))
                    return true;
            }
            return false;
        }
    }
}

