/*
 * @lc app=leetcode id=1046 lang=csharp
 *
 * [1046] Last Stone Weight
 */

// @lc code=start
public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> queue=new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));
        for(var x=0; x<stones.Length;++x){
            queue.Enqueue(stones[x],stones[x]);
        }
        while(queue.Count>1){
            int val=queue.Dequeue()-queue.Dequeue();
            queue.Enqueue(val,val);
        }
        return queue.Dequeue();
    }
}
// @lc code=end