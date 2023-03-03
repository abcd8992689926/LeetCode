/*
 * @lc app=leetcode id=215 lang=csharp
 *
 * [215] Kth Largest Element in an Array
 */

// @lc code=start
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> queue=new();
        for(var x=0;x<nums.Length; ++x){
            queue.Enqueue(nums[x],nums[x]);
            if(queue.Count>k){
                queue.Dequeue();
            }
        }
        return queue.Peek();
    }
}
// @lc code=end

