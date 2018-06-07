using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        public int arrCount;
        public int capacity;
        T[] arr;
        public CustomList()
        {
            capacity = 5;
            arr = new T[capacity];
            arrCount = 0;

        }

        public void Add(T inputValue)
        {
                 //add the th8ng
                // handle the count
                // check capacity
        }
    }
}
