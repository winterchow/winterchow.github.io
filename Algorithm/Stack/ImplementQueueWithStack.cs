public class MyQueue {
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();
    /** Initialize your data structure here. */
    public MyQueue() {
        
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        stack1.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        if(stack2.Count == 0){
            while(stack1.Count != 0){
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        if(stack2.Count == 0){
            while(stack1.Count != 0){
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}