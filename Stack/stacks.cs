namespace stack{
	class intStack{
		private IntNode head;
		public void Push(int value){
			IntNode newintnode = new IntNode(value);
			newintnode.Last = head;
			head = newintnode;
		}
		
		public void Pop(){
			head = head.Last;
		}
		
		public int Top(){
			return head.Data;
		}
		
	}
	
}