using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    public interface MyIEnumerable<T>
    {
        IEnumerator<T> GetEnumerator();
    }
}

