/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest {
    private List<int> c=new List<int>();
    private int l=0;
    public KthLargest(int k, int[] nums) {
        this.l=k;
        Array.Sort(nums, (a, b) => b - a);
        int end=nums.Length;
        if(k<nums.Length){
            end=k;
        }
        for(var x=0; x<nums.Length; ++x){
            c.Add(nums[x]);
        }
        //c.AddRange(nums[0]);
        //sort();
    }
    public int Add(int val) {
        c.Add(val);
        //sort();
        return c.Last();
    }
    private void sort(){
        //c.Sort((a,b)=>b.CompareTo(a));
        if(c.Count>this.l){
            c=c.GetRange(0,this.l);
        }
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

