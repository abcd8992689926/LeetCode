/*
 * @lc app=leetcode id=674 lang=csharp
 *
 * [674] Longest Continuous Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if(nums==null||nums.Length==0){
            return 0;
        }
        List<int> rs=new List<int>();
        int max=1;
        rs.Add(nums[0]);
        for(var x=1; x<nums.Length; ++x){
            if(nums[x]>rs.Last()&&nums[x]!=rs.Last()){
                rs.Add(nums[x]);
                max=Math.Max(max, rs.Count);
                continue;
            }
            rs=new List<int>{nums[x]};
        }
        return max;
    }
}
// @lc code=end

