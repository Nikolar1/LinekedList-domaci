using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    struct Ucenik{
      string ime;
      string prezime;
      int razred;
      int rednibr;
    };

    class Node
    {
      public Ucenik Data{get; set;}
      public Node Next{get; set;}
      public Node Last{get; set;}

      public Node(Ucenik data = 0)
      {
          this.Data = data;
      }

      public Node(Ucenik data, Node next, Node last)
      {
          Data = data;
          Next = next;
          Last = last;
      }
    }
}
