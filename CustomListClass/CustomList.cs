using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private int counter;
        private int capacity;
        private T[] arr;
         public CustomList()
        {
            counter = 0;
            capacity = 5;
            arr = new T[capacity];
        }
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }
        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public void Add(T nextElement)
        {
        //[]fooArray = new fooArray[9];
            if (counter == capacity)
            {
                GrowList();
            }
            arr[counter] = nextElement;
            counter++;
        }
        public void GrowList()
        {
            T[] tempArr = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
            {
                tempArr[i] = arr[i];
            }
            capacity *= 2;
            arr = tempArr;
        }
    }
}
