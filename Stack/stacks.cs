namespace stack{
	class IntStack{
		private IntNode head;
		private int kapacitet = 50;
		private int brel = 0;
		
		public void IsFull(){
			bool provera = false;
			if(brel>=kapacitet){
				provera = true;
			}
			return provera;
		}
		
		public void Push(int value){
			if (!IsFull()){
				IntNode newintnode = new IntNode(value);
				newintnode.Last = head;
				head = newintnode;
				brel++;
			}
		}
		
		public bool IsEmpty(){
			bool provera = false;
			if (head == null){
				provera==true;
			}
			return provera;
		}
		
		public void Pop(){
			if(!IsEmpty()){
				head = head.Last;
				brel--;
			}
		}
		
		public int Top(){
			return head.Data;
		}
		
	}
	
}
