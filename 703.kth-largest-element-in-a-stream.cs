/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest{
    private readonly int _k;
    private PriorityQueue<int, int> queue = new();
    public KthLargest(int k, int[] nums)
    {
        _k = k;
        for (var x=0; x<nums.Length;++x)
        {
            Add(nums[x]);
        }
    }

    public int Add(int val) {
        queue.Enqueue(val, val);

        if (queue.Count > _k) queue.Dequeue();

        return queue.Peek();
    }
}
/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

