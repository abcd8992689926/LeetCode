/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 */

// @lc code=start
public class Solution {
    private Queue<int> queue=new Queue<int>();
    public int[] NextGreaterElements(int[] nums) {
        var r=new List<int>();
        queue.Enqueue(nums[0]);
        for(var x=1; x<nums.Length; ++x){
            while(queue.Peek()<nums[x]){
                queue.Dequeue();
            }
            if(queue.Count==0){
                queue.Enqueue(nums[x]);
            }
            if(x!=nums.Length-1&&nums[x]>nums[x+1]){
                r.Add(-1);
            }else{
                r.Add(queue.Peek());
            }
        }
        if(r.Count==0){
            r.Add(queue.Peek());
        }
        return r.ToArray();
    }
}
// @lc code=end