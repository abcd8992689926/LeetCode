/*
 * @lc app=leetcode id=295 lang=csharp
 *
 * [295] Find Median from Data Stream
 */

// @lc code=start
public class MedianFinder {
    private PriorityQueue<int,int> l;
    private PriorityQueue<int,int> s;
    public MedianFinder() {
        l=new PriorityQueue<int,int>(Comparer<int>.Create((x,y)=>y.CompareTo(x)));
        s=new PriorityQueue<int,int>();
    }
    
    public void AddNum(int num) {
        if(l.Count==0||num<l.Peek()){
            l.Enqueue(num,num);
            if(l.Count>s.Count+1){
                var tmp=l.Dequeue();
                s.Enqueue(tmp,tmp);
            }
        }else{
            s.Enqueue(num,num);
            if(s.Count>l.Count){
                var tmp=s.Dequeue();
                l.Enqueue(tmp,tmp);
            }
        }
    }
    
    public double FindMedian() {
        if(l.Count==s.Count){
            return (l.Peek()+s.Peek())/2.0;
        }else{
            return l.Peek();
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
// @lc code=end
