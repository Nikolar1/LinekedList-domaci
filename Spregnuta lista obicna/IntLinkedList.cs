using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    class IntLinkedList
    {
        //sve je private, nista ne odajemo
        private IntNode head;


        public void AddFirst(int data)
        {
            IntNode newNode = new IntNode(data);

            //ne mora
            //if (head == null)
            //{
            //    head = newNode;
            //    return;
            //}

            newNode.Next = head;
            head = newNode;
        }


        public void AddLast(int data)
        {
            IntNode newNode = new IntNode(data);

            if (IsEmpty())
            {
                head = newNode;
                return;
            }

            IntNode temp = head;
            while(temp.Next != null)  //ne mozemo tmp != null jer cemo preskociti poslednji element na koji treba da se zakacimo. Zato moramo i ostaviti onu gore proveru za head == null
            {
                temp = temp.Next;
            }
            //sa petljom iznad samo prolazimo kroz listu dok ne stignemo do kraja
            //na kraju petlje se nalazimo na poslednjem elementu
            //ostalo je jos samo da se zakacimo za njega
            temp.Next = newNode;


            //ovde je, recimo, specijalan slucaj i kad lista ima jedan elemenat, proveris na brzaka, u glavi, jel i to ok


        }

        public int Length()
        {
            int length = 0;
            IntNode temp = head;
            while(temp != null){
              lenght++;
              temp = temp.Next;
            }
            return length;
        }


        public bool Add(int data, int index)
        {
            //TODO implement
            //true ako uspe da doda, false ako ne, npr ako neko zada neispravan index
            //index ide od 0
            IntNode newNode = new IntNode(data);
            bool provera = true;
            if(index == 0){
              AddFirst(data);
            }
            else if(IsEmpty()){
                provera = false;
            }
            else if(Length() < index+1){
              provera = false;
            }
            else if(Length() == index){
              AddLast(data);
            }
            else{
              IntNode temp = head;
              IntNode tempstari = head;
              int brojac = 0;
              while(brojac < index)
              {
                  tempstari = temp;
                  temp = temp.Next;
                  brojac++;
              }
              newNode.Next = temp;
              tempstari.Next = newNode;
            }
            return provera;
        }


        public override string ToString()
        {
            string str = "";
            if (IsEmpty())
            {
                return "prazna"; //ili "" i tom slucaju ceo if ne mora da postoji
            }

            IntNode temp = head;

            while (temp != null)
            {
                str += (temp.Data + " ");
                temp = temp.Next;
            }
            return str;
        }

        public bool IsEmpty(){
          bool provera = false;
          if (head == null)
          {
              provera = true;
          }
          return provera;
        }

        public void Clear(){
          IntNode temp = head;
          IntNode obrisi = temp;
          while(temp != null){
            temp = temp.Next;
            obrisi = null;
            obrisi = temp;
          }
        }

        public void DeleteFirst(){
          intNode temp = head;
          head = head.Next;
          temp = null;
        }

        public void DeleteLast(){
          IntNode temp = head;
          while(temp.Next != null){
            temp = temp.Next;
          }
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
            IntNode temp = head;
            IntNode tempstari = head;
            int brojac = 0;
            while(brojac < index)
            {
                tempstari = temp;
                temp = temp.Next;
                brojac++;
            }
            tempstari.Next = temp.Next;
            temp = null;
          }
          return provera;
        }

        public int FindFirst(){
          IntNode temp = head;
          return temp.Data;
        }

        public int FindLast(){
          IntNode temp = head;
          while(temp.Next != null){
            temp = temp.Next;
          }
          return temp.Data;
        }

        public bool Edit(int data, int index){
          bool provera = true;
          IntNode temp = head;
          if(index == 0){
            temp.Data = data;
          }
          else if(IsEmpty()){
              provera = false;
          }
          else if(Length() < index+1){
            provera = false;
          }
          else if(Length() == index){
            while(temp.Next != null){
              temp = temp.Next;
            }
            temp.Data = data;
          }
          else{
            int brojac = 0;
            while(brojac < index)
            {
                temp = temp.Next;
                brojac++;
            }
            temp.Data = data;
          }
          return provera;
        }

        public void Reverse(){
            if(!IsEmpty()){
              IntNode temp = head.Next
              IntNode tempstari = temp;
              IntNode tempstariji = head;
              IntNode templast = head
              while(templast.Next != null){
                templast = templast.Next;
              }
              head.Next = templast;
              while(temp != null){
                tempstari.Next = tempstariji;
                tempstariji = tempstari;
                tempstari = temp;
                temp = temp.Next;
              }
            }
        }

        public int Sum(){
          IntNode temp = head;
          int suma = 0;
          while(temp != null){
            suma = suma + temp.Data
            temp = temp.Next;
          }
          return suma;
        }

        public int[] ToArray(){
          IntNode temp = head;
          int[] niz = new int[Length()];
          int brojac = 0;
          while(temp != null){
            niz[brojac] = temp.Data;
            temp = temp.Next;
            brojac++;
          }
          return niz[];
        }
        public void Merge (IntNode head2){
          IntNode temp = head;
          IntNode temp2 = head2;
          while(temp.Next != null){
            temp = temp.Next;
          }
          while(temp2 != null){
            temp.Next = temp2;
            temp2 = temp2.Next;
            temp = temp.Next;
          }
        }

        public void tritacke(){
          Console.WriteLine("...");
        }
        //...  implementirano
        //IsEmpty implementirano
        //Length implementirano
        //Clear implementirano
        //DeleteFirst implementirano
        //DeleteLast implementirano
        //Delete (indeks) implementirano
        //FindFirst (data) implementirano
        //FindLast (data) implementirano
        //Edit(int newdata, int index) implementirano
        //Reverse implementirano
        //Sum  implementirano
        //ToArray implementirano
        //Merge dve liste implementirano

        //Razno Ne razumem sta ovde treba?
        //DeleteAll (int) Zar ovo nije isto sto i clear?
        //Add zadati IntNode (sve tri varijante) Ne razumem sta ovde treba?

    }
}
