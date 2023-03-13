/*
 * @lc app=leetcode id=232 lang=csharp
 *
 * [232] Implement Queue using Stacks
 */

// @lc code=start
public class MyQueue {
    private Queue<int> queue;
    public MyQueue() {
        queue=new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
    }
    
    public int Pop() {
        return queue.Dequeue();
    }
    
    public int Peek() {
        return queue.Peek();
    }
    
    public bool Empty() {
        if(queue.Count==0){
            return true;
        }else{
            return false;
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

