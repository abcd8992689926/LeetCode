/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 */

// @lc code=start
public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var l=nums.Length;
        var r=new int[l];
        var s=new Stack<int>();
        Array.Fill(r, -1);
        for(var x=0; x<l*2; ++x){
            var i=x%l;
            while(s.Count>0&&nums[s.Peek()]<nums[i]){
                r[s.Pop()]=nums[i];
            }
            s.Push(i);
        }
        return r;
    }
}
// @lc code=end