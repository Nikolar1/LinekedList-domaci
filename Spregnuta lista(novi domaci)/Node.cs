using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Node
    {
      public int Data {get; set;}
      private Node Next{get; set;}
      private Node Last{get; set;}

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
