using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    class Program
    {
        static void Main(string[] args)
        {
            IntNode node1 = new IntNode();
            IntNode node2 = new IntNode(5);
            IntNode node3 = new IntNode(3, node2);

            IntLinkedList list = new IntLinkedList();


            Console.WriteLine("-------------------");
            list.AddFirst(12);
            Console.WriteLine(list.ToString());

            list.AddFirst(5);
            Console.WriteLine(list.ToString());

            Console.WriteLine("-------------------");
            list.AddLast(2);
            Console.WriteLine(list.ToString());


            //testiranje dodavanja na proizvoljnu poziciju
            Console.WriteLine("-------------------");
            //ocekujemo da ne radi
            if (!list.Add(3, -12))
                Console.WriteLine("Greska");
            else
                Console.WriteLine(list);

            //ocekujemo da ne radi
            if (!list.Add(3, 12))
                Console.WriteLine("Greska");
            else
                Console.WriteLine(list);


            //ocekujemo da radi
            if (!list.Add(3, 1))
                Console.WriteLine("Greska");
            else
                Console.WriteLine(list);

            //isto kao AddFirst
            if (!list.Add(6, 0))
                Console.WriteLine("Greska");
            else
                Console.WriteLine(list);

            //isto kao AddLast
            if (!list.Add(4, list.Length()))
                Console.WriteLine("Greska");
            else
                Console.WriteLine(list);




        }
    }
}
