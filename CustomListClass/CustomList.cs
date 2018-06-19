using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T>
    {
        private int counter;
        private int capacity;
        private T[] arr;
        private string stringify;
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
        public string Stringify
        {
            get
            {
                return stringify;
            }
            set
            {
                stringify = value;
            }
        }
        public void Add(T nextElement)
        {
            if (counter == capacity)
            {
                GrowArray();
            }
            arr[counter] = nextElement;
            counter++;
        }
        public bool Remove(T element)
        {
            for (int i = 0; i < counter; i++)
            {
                if (arr[i].Equals(element))
                {
                    arr[i] = arr[i + 1];
                    return true;
                }
            }
            return false;
        }
        public void GrowArray()
        {
            T[] tempArr = new T[capacity * 2];
            for (int i = 0; i < counter; i++)
            {
                tempArr[i] = arr[i];
            }
            capacity *= 2;
            arr = tempArr;
        }
        public override string ToString()
        {
            string stringify = null;
            for (int i = 0; i < counter; i++)
            {
                stringify += arr[i] + " ";
            }
            return stringify;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return arr[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
