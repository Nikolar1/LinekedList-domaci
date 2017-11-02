using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List{
  class LinkedList{
    private Node head;
    private Node tail;
    private int lenght = 0;

    public void AddFirst(Ucenik data){
      Node newNode = new Node(data);
      newNode.Next = head;
      newNode.Last = tail;
      head = newNode;
      tail.Next = newNode;
      if(IsEmpty()){
        tail = newNode;
      }
      lenght++;
    }

    public void AddLast(Ucenik data){
      Node newNode = new Node(data);
      if (IsEmpty()){
        AddFirst(data);
      }
      else{
        newNode.Next = head;
        newNode.Last = tail;
        tail = newNode;
        lenght++;
      }
    }

    public void Add(Ucenik data, int index){
      Node newNode = new Node(data);
      if(!IsEmpty() && index < lenght){
        int lokacija = 0;
        Node temp = head;
        while(lokacija <= index){
          if(lokacija == index){
            newNode.Next = temp;
            newNode.Last = temp.Last;
            temp.Last = newNode
            lenght++;
          }
          temp = temp.Next
          lokacija++;
        }
      }
      else if(!IsEmpty() && index == lenght){
        AddLast(data);
      }
      else if(IsEmpty()){
        AddFirst(data);
      }
    }

    public bool IsEmpty(){
      bool provera = false;
      if(head == null){
        provera = true;
      }
      return provera;
    }



    //Funkcije su slicne kao kod ostalih lista uz male promene



  }
}
