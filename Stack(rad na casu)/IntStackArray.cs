using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
        class IntStackArray
        {
            private int capacity = 10;
            private int[] array;
            private int top;


            public IntStackArray()
            {
                top = -1;
                array = new int[capacity];
            }

            public IntStackArray(int initialCapacity)
            {
                capacity = initialCapacity;
                top = -1;
                array = new int[capacity];
            }

            public int GetCapacity()
            {
                return capacity;
            }

            public int GetSize()
            {
                return top;
            }

            public bool IsEmpty()
            {
                bool provera = false;
                if(top == -1) {
                  provera = true;
                }
                return provera;

            }

            public bool IsFull()
            {
            bool provera = false;
            if(top == capacity)
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
