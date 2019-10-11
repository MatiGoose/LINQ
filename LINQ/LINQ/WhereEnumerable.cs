using System;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    public class WhereEnumerable<Tsource> : MyIEnumerable<Tsource>, IEnumerator<Tsource>
    {
        private MyIEnumerable<Tsource> source;
        private Func<Tsource, bool> cond;
        private Tsource current;
        public WhereEnumerable(MyIEnumerable<Tsource> source, Func<Tsource, bool> cond)
        {
            this.source = source;
            this.cond = cond;
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
            if (source.GetEnumerator().MoveNext())
            {
                while(!cond(source.GetEnumerator().Current))
                {
                    source.GetEnumerator().MoveNext();
                }
                current = source.GetEnumerator().Current;

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

