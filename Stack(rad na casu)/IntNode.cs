using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class IntNode
    {
        public int Data { get; set; }
        public IntNode Next { get; set; }

        public IntNode(int data = 0, IntNode next = null)
        {
            Data = data;
            Next = next;
        }

        public IntNode(int data)
        {
            Data = data;
            Next = null;
        }

    }
}
