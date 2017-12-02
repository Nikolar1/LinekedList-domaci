using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class IntStackList2
    {
        private IntNode top;
        private int size;
        private int capacity; // pamti duzinu steka

        public IntStackList2()
        {
            top = null;
            size = 0;
        }

        public IntStackList2(int capacity)
        {
            top = null;
            size = 0;
            this.capacity = capacity;
        }



        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            bool provera = false;
            if (top == null)
            {
                provera = true;
            }
            return provera;

        }

        public bool IsFull()
        {
            bool provera = false;
            if(size == capacity)
            {
                provera = true;
            }
            return provera;

        }

        public int Top()
        {
            return top.Data;

        }

        public bool Push(int value)
        {
            bool provera = false;
            if (size < capacity)
            {
                IntNode temp = new IntNode(value);
                temp.Next = top;
                top = temp;
                size++;
                provera = true;
            }
            return provera;

        }

        public bool Pop()
        {
            bool provera = false;
            if (!IsEmpty())
            {
                top = top.Next;
                provera = true;
                size--;
            }
            return provera;

        }
    }
 }
