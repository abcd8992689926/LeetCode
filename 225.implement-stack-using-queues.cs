/*
 * @lc app=leetcode id=225 lang=csharp
 *
 * [225] Implement Stack using Queues
 */

// @lc code=start
public class MyStack {
    private Stack<int> stack;
    public MyStack() {
        stack=new Stack<int>();
    }
    
    public void Push(int x) {
        stack.Push(x);
    }
    
    public int Pop() {
        return stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public bool Empty() {
        if(stack.Count==0){
            return true;
        }else{
            return false;
        }
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

