using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntStackList2 stek = new IntStackList2(1);
            stek.Push(5);
            stek.Push(9);
            stek.Push(25);
            stek.Pop();
            stek.Push(5);
            stek.Push(9);
            stek.Push(25);
            Console.WriteLine(stek.Top());
            Console.ReadLine();
        }

        public bool Swap(IntStackArray s)
        {
            bool provera = false;
            if(s.GetSize() >= 2)
            {
                provera = true;
                int temp1 = s.Top();
                s.Pop();
                int temp2 = s.Top();
                s.Pop();
                s.Push(temp1);
                s.Push(temp2);
            }
            return provera;
        }

        public bool Rotate(IntStackArray s, int n)
        {
            bool provera = false;
            if (n <= s.GetSize())
            {
                int[] niz = new int[n];
                int i = 0;
                while (i < n)
                {
                    niz[i] = s.Top();
                    s.Pop();
                    i++;
                }
                i = 0;
                while (i < n)
                {
                    s.Push(niz[i]);
                    i++;
                }
                provera = true;
            }

            return provera;
        }

    }
}
