namespace Stack{
	class intqueueStack(){
		private IntNode head;
		// queue "First in first out"
		public void Push(int value){
			IntNode newintnode = new IntNode();
			if(head == null){
				head = newintnode;
			}
			else{
				IntNode temp = head;
				while(temp.Next != null){
					temp = temp.Next;
				}
				temp.Next = newintnode;
			}
		}
		
		public void Pop(){
			head = head.Next;
		}
		
		public int Top(){
			return head.Data;
		} 
	}
	
}