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
        tempstariji = temp;
        temp = temp.Next;
      }while(temp.Data < newNode.Data && temp.Next != null)
    }
    
    public void Merge(Node head2){
      Node temp = head2;
      while(temp!= null){
        Add(temp.Data);
        temp=temp.Next;
      }
    }

    public bool IsEmpty(){
      bool provera = false;
      if(head == null){
        provera = true;
      }
      return provera;
    }



    public void DeleteFirst(){
      intNode temp = head;
      head = head.Next;
      temp = null;
    }

    public void DeleteLast(){
      Node temp = head;
      while(temp.Next != null){
        temp = temp.Next;
      }
      Node tempstariji = temp.Last;
      tempstariji.Next = null;
      temp = null;
    }

    public bool Delete(int index){
      bool provera = true;
      if(index == 0){
        DeleteFirst();
      }
      else if(IsEmpty()){
          provera = false;
      }
      else if(Length() < index+1){
        provera = false;
      }
      else if(Length() == index){
        DeleteLast();
      }
      else{
        Node temp = head;
        Node tempstariji = head;
        int brojac = 0;
        while(brojac < index)
        {
            tempstariji = temp;
            temp = temp.Next;
            brojac++;
        }
        Node tempnoviji;
        tempstariji.Next = temp.Next;
        tempnoviji = temp.Next;
        tempnoviji.Last = tempstariji
        temp = null;
      }
      return provera;
    }
    // Funkcije su slicne kao kod ostalih lista uz male promene
  }
}
