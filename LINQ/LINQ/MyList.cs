using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    public class MyList<T> : MyIEnumerable<T>, IEnumerator<T>
    {
        List<T> list;
        public MyList()
        {
            this.list = new List<T>();
        }
        public MyList(T[] mass)
        {
            this.list = new List<T>();
            for(int i = 0; i < mass.Length; i++)
            {
                this.list.Add(mass[i]);
            }
        }
        
        public void Add(T value)
        {
            list.Add(value);
        }
        public void Remove(T value)
        {
            list.Remove(value);
        }
        public void Clear()
        {
            list.Clear();
        }
        int index = -1;


        object IEnumerator.Current => list[index];

        T IEnumerator<T>.Current => list[index];

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        public T this[int index]
        {
            get
            {
                return (T)list[index];
            }
            set
            {
                list[index] = value;
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[list.Count];
            return array;
        }
        public bool MoveNext()
        {
            if (index == list.Count - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose(){}
    }
}

