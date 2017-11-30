namespace Stack{
	class intnizStack{
		private const int duzinasteka = 255;
		private int[] stack = new int[duzinasteka];
		private int index = -1;
		public void Push(int value){
			if (index+1<duzinasteka){
				index++;
				stack[index] = value;
				
			}
			
		}
		
		public void Pop(){
			if(index != -1){
				stack[index] = 0;
				index--;
			}
		}
		
		public int Top(){
			return stack[index];
		}
		
	}
	
}