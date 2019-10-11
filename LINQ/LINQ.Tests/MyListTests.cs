using System;
using Xunit;

namespace LINQ.Tests
{
    
    public class MyListTests
    {
        [Fact]
        public void ToArray_ConvertListToIntArray_IntArray()
        {
            MyList<int> list = new MyList<int>();
            for(int i =0;i<4;i++)
            {
                list.Add(i);
            }
            var array = list.ToArray();
            Assert.IsType<int[]>(array);
        }
        [Fact]
        public void Indexer_Get2From1Index_Return2()
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var element = list[1];
            Assert.Equal(2, element);
        }
        [Fact]
        public void Clear_DeleteListElements_Return0()
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();
            var size = list.Length();
            Assert.Equal(0, size);
        }
        [Fact]
        public void Size_GetListLength_Return3()
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var size = list.Length();
            Assert.Equal(3, size);
        }
    }
}
