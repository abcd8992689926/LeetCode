/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var rs = new List<IList<int>>();
        for (int i = 0; i < (int)Math.Pow(2, nums.Length); i++)
        {
            rs.Add(GetItems(TransformToBoolArray(i, nums.Length), nums));
        }
        return rs;
    }
    private List<int> GetItems(bool[] boolArray, int[] nums)
    {
        var rs = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (boolArray[i]) rs.Add(nums[i]);
        }
        return rs;
    }
    private bool[] TransformToBoolArray(int n, int length)
    {
        var rs = new bool[length];
        var index = length - 1;
        while(n > 0)
        {
            rs[index] = n % 2 == 1;
            n /= 2;
            index--;
        }
        return rs;
    }
}
// @lc code=end

