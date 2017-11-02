using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace List{
  class sortLinkedList{
    private Node head;
    private int lenght = 0;

    private void AddFirst(int data)
    {
      Node newNode = new Node(data);
      newNode.Next = head;
      head = newNode;
      lenght++;
    }

    public void Add(int data){
      Node newNode = new Node(data);
      if(IsEmpty()){
        AddFirst(data);
      }
      Node temp = head;
      Node tempstariji;
      do{
        if(temp.Data > newNode.Data && temp == head){
          AddFirst(data);
          lenght++;
        }
        else if(temp.Data > newNode.Data){
          tempstariji = temp.Last;
          temp.Last = newNode;
          tempstariji.Next = newNode;
          newNode.Next = temp;
          newNode.Last = tempstariji;
          lenght++;
        }
        else if(temp.Next == null){
          temp.Next = newNode;
          newNode.Last = temp;
          lenght++
        }
        temp = temp.Next;
      }while(temp.Data < newNode.Data && temp.Next != null)
    }

    public bool IsEmpty(){
      bool provera = false;
      if(head == null){
        provera = true;
      }
      return provera;
    }

    // Funkcije su slicne kao kod ostalih lista uz male promene
  }
}
