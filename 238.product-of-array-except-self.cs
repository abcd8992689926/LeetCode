/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var r=new int[nums.Length];
        r[0]=1;
        for(var x=1; x<nums.Length; ++x){
            r[x]=r[x-1]*nums[x-1];
        }
        var right=1;
        for(var x=nums.Length-1; x>-1; --x){
            r[x]*=right;
            right*=nums[x];
        }
        return r;
    }
}
// @lc code=end