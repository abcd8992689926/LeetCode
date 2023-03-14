/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 */

// @lc code=start
public class Solution {
    private Queue<int> queue=new Queue<int>();
    public int[] NextGreaterElements(int[] nums) {
        var l=nums.Length;
        var stack=new Stack<int>();
        int[] r=new int[l];
        Array.Fill(r, -1);
        for(var x=0; x<l*2; ++x){
            var i=x%l;
            while(stack.Count>0&&nums[stack.Peek()]<nums[i]){
                r[stack.Pop()]=nums[i];
            }
            if(i<l){
                stack.Push(i);
            }
        }
        return r;
    }
}
// @lc code=end