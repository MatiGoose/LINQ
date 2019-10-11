using System;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    public class SelectEnumerable<Tsource> : MyIEnumerable<Tsource>, IEnumerator<Tsource>
    {
        private MyIEnumerable<Tsource> source;
        private Func<Tsource, Tsource> fun;
        private Tsource current;
        public SelectEnumerable(MyIEnumerable<Tsource> source, Func<Tsource, Tsource> fun)
        {
            this.source = source;
            this.fun = fun;
        }
        public Tsource Current => current;

        object IEnumerator.Current => current;

        public void Dispose() { }

        public IEnumerator<Tsource> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if(source.GetEnumerator().MoveNext())
            {
                current = fun(source.GetEnumerator().Current);
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            source.GetEnumerator().Reset();
        }
    }


}

