/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {        
        var res = new List<IList<int>>();
        Array.Sort(nums);
        Backtrack(res, new List<int>(), nums,0);
        return res;
    }

    private void Backtrack(IList<IList<int>> res, List<int> subsets, int[] nums, int start)
    {
        res.Add(new List<int>(subsets));
            
        for (int i = start; i < nums.Length; i++)
        {
            subsets.Add(nums[i]);
            Backtrack(res, subsets, nums, i + 1);
            subsets.RemoveAt(subsets.Count - 1);
        }
    }    
}
// @lc code=end

