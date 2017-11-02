using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{

    class Node
    {
      public int Data{get; set;}
      public Node Next{get; set;}
      public Node Last{get; set;}

      public Node(int data = 0)
      {
          this.Data = data;
      }

      public Node(int data, Node next, Node last)
      {
          Data = data;
          Next = next;
          Last = last;
      }
    }
}
