/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
public class Solution {
	public int LengthOfLIS(int[] nums) {
		List<LinkedList<int>> patience = new List<LinkedList<int>>();
		foreach (var x in nums)
		{
			int left = 0;
			int right = patience.Count - 1;
			while (left <= right)
			{
				int mid = (left + right) / 2;
				if (patience[mid].Last.Value < x)
					left = mid + 1;
				else right = mid - 1;
			}
			if (left >= patience.Count) patience.Add(new LinkedList<int>(new[] {x}));
			else patience[left].AddLast(x);
		}

		return patience.Count;
	}
}
// @lc code=end

