using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class IntStackList
    {

        private IntNode top;
        private int size; // pamti duzinu steka

        public IntStackList()
        {
            top = null;
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            bool provera = false;
            if(top == null)
            {
                provera = true;
            }
            return provera;

        }


        public int Top()
        {
            return top.Data;

        }

        public void Push(int value)
        {
            IntNode temp = new IntNode(value);
            temp.Next = top;
            top = temp;
            size++;
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
