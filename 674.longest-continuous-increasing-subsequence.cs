/*
 * @lc app=leetcode id=674 lang=csharp
 *
 * [674] Longest Continuous Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        List<int> rs=new List<int>();
        int max=0;
        rs.Add(nums[0]);
        for(var x=1; x<nums.Length; ++x){
            int []c=new int[]{rs.Last()+1,rs.Last()-1};
            if(c.Contains(nums[x])==false){
                rs.Add(nums[x]);
                continue;
            }
            max=Math.Max(max, rs.Count);
            rs=new List<int>{nums[x]};
        }
        return max;
    }
}
// @lc code=end

