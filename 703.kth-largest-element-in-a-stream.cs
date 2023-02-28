/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest {
    public List<List<int>> c=new List<List<int>>();
    public KthLargest(int k, int[] nums) {
        c.Add(new List<int>());
        c[0].Add(k);
        foreach(var x in nums){
            Add(x);
        }
    }
    
    public int Add(int val) {
        
        return 0;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

