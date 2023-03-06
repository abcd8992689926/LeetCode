/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var r=new Dictionary<int,int>();
        var rs=new int[k];
        for(var x=0; x<nums.Length; ++x){
            if(r.ContainsKey(nums[x])){
                r[nums[x]]++;
            }else{
                r.Add(nums[x],1);
            }
        }
        var tmp=r.OrderByDescending(x=>x.Value).ToList();
        for(var x=0; x<tmp.Count; ++x){
            if(k==0){
                break;
            }
            rs[x]=tmp[x].Key;
            k--;
        }
        return rs;
    }
}
// @lc code=end

