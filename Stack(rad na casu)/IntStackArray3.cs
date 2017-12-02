using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class IntStackArray3
    {
        private int capacity = 4;
        private int[] array;
        private int top;


        public IntStackArray3()
        {
            top = -1;
            array = new int[capacity];
        }

        public IntStackArray3(int initialCapacity)
        {
            capacity = initialCapacity;
            top = -1;
            array = new int[capacity];
        }

        public int GetCapacity()
        {
            return capacity;
        }

        private bool SetCapacity(int newCapacity)
        {
            bool provera = false;
            if (newCapacity > capacity)
            {
                provera = true;
                int[] niz = new int[newCapacity];
                int i = 0;
                while (i <= top)
                {
                    niz[i] = array[i];
                    i++;
                }
                array = niz;
                capacity = newCapacity;
            }
            return provera;
        }



        public int GetSize()
        {
            return top;
        }

        public bool IsEmpty()
        {
            bool provera = false;
            if (top == -1)
            {
                provera = true;
            }
            return provera;

        }

        public bool IsFull()
        {
            bool provera = false;
            if (top == capacity)
            {
                provera = true;
            }
            return provera;

        }

        public int Top()
        {
            return array[top];

        }

        public bool Push(int value)
        {
            if (top + 1 < capacity)
            {
                top++;
                array[top] = value;

            }
            else
            {
                SetCapacity(capacity * 2);
                Push(value);
            }
            return false;
        }

        public bool Pop()
        {
            if (top != -1)
            {
                array[top] = 0;
                top--;
            }
            return false;
        }


    }
}
