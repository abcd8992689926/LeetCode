/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest {
    private List<int> c=new List<int>();
    private int l=0;
    private int current=int.MinValue;
    public KthLargest(int k, int[] nums) {
        this.l=k;
        if(nums.Length==0){
            return;
        }
        Array.Sort(nums, (a, b) => b - a);
        int end=nums.Length;
        if(k<nums.Length){
            end=k;
        }
        for(var x=0; x<nums.Length; ++x){
            c.Add(nums[x]);
        }
        this.current=c.Last();
    }
    public int Add(int val) {
        if(this.current<val){
            c.Add(val);
            sort();
        }
        return c.First();
    }
    private void sort(){
        if(c.Count>this.l){
            c.Sort();
            c=c.GetRange(c.Count-this.l,this.l);
        }
    }
}
/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

