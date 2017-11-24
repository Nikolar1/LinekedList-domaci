using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List{
    class Program{
        static void Main(string[] args){
          IntNode node1 = new IntNode();
          IntNode node2 = new IntNode(5);
          IntNode node3 = new IntNode(3, node2);
          IntList lista = new IntList();
          lista.Add(6);
          lista.Add(2);
          lista.Add(1);
          lista.Add(3);
          lista.Add(8);
          Console.WriteLine(lista.Lenght());
          Console.WriteLine(lista.Find(2));
          lista.Delete(3);
        }
    }
}
