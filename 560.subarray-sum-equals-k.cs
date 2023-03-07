/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var r=0;
        var sum=0;
        var d=new Dictionary<int,int>();
        d.Add(0,1);
        for(var x=0; x<nums.Length; ++x){
            sum+=nums[x];
            int tmp=sum-k;
            if(d.ContainsKey(tmp)){
                r+=d[tmp];
            }
            if(d.ContainsKey(sum)){
                d[sum]++;
            }else{
                d.Add(sum, 1);
            }
        }
        return r;
    }
}
// @lc code=end
