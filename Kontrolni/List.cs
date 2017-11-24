namespace List{
	class IntList{
		private IntNode head;
		private IntNode tail;

		public bool IsEmpty(){
			bool provera = false;
			if(head == null){
				provera = true;
			}
			return provera;
		}

		public int Lenght(){
			int brojac = 0;
			IntNode temp = head;
			if(!IsEmpty()){
				brojac++;
				while(temp!=tail){
					temp = temp.Next;
					brojac++;
				}

			}

			return brojac;
		}

		public int Find(int value){

			int index = -1;
			int brojac = 0;
			IntNode temp = head;
			if(!IsEmpty){
				do{
					if(temp.data == value){
						index = brojac;
					}
					temp = temp.next
					brojac++;
				}while(temp != null)
			}
			return index;
		}

		public bool Add(int value){
			bool provera = false;
			IntNode newnode = new IntNode(value);
			if(IsEmpty()){
				head = newnode;
				tail = newnode;
				newnode.Next = tail;
				provera = true;
			}
			else if(Lenght() == 1){
				if(head.data > value){
					newnode.Next = head;
					tail = head;
					head = newnode;
					provera = true;
				}
				else if(head.data != value){
					head.Next = newnode;
					tail = newnode
					provera = true;
				}
			}
			else if(head.data > value){

				newnode.Next = head;
				head = newnode;
				provera = true;
			}
			else{

				IntNode temp = head;
				IntNode tempstari = temp;
				do{
					if(temp.data > value && tempstari.data != value){
						newnode.Next = temp;
						tempstari.Next = newnode
						return true;
					}
					tempstari = temp;
					temp = temp.Next;
				}while(temp != tail)
				if(temp.data > value && tempstari.data != value){
					tail.Next = newnode;
					tail = newnode;
					provera = true;
				}
			}
			return provera;
		}

		public bool Delete(int index){
			bool provera = false;
			if(!IsEmpty() && index < Lenght){
				if(index == 0){
					head = head.Next;
					provera = true;
				}
				else{
					IntNode temp = head;
					IntNode tempstari = temp;
					int brojac = 0
					while (brojac != index){
						brojac++;
						tempstari = temp;
						temp = temp.Next;
					}
					tempstari.Next = temp.Next;
					temp = null;
					provera = true;
				}
			}
			return provera;
		}

	}

}
