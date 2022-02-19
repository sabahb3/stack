namespace StackTask
{
    public class Stack<T>
    {
        private class StackEntry<TEntry>{
            public StackEntry<TEntry>? next=null;
            public TEntry? data;
        }

        private StackEntry<T>? top=null;

        public void Push(T value){
            StackEntry<T> entry=new StackEntry<T>{data=value};
            if(top==null){
                top=entry;
            }
            else {
                entry.next=top;
                top=entry;
            }
        }
        public void Print(){
            string stackElements="";
            if(top!=null){
                StackEntry<T>? curr=top;
                while(curr!=null){
                    stackElements+=curr.data!.ToString()+" ";
                    curr=curr.next;
                }
            }
            Console.WriteLine(stackElements);
        }

        public T? Pop(){
                if(top!=null){
                T data = top.data!;
                top=top.next;
                return data;
            }
            else 
            {
                Console.WriteLine("Stack is empty");
                Exception ex=new Exception("THe stack is Empty");
                throw(ex);
            }


              
        }
    }
}