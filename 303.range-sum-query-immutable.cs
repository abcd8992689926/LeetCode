/*
 * @lc app=leetcode id=303 lang=csharp
 *
 * [303] Range Sum Query - Immutable
 */

// @lc code=start
public class NumArray {
    private readonly int[] preSums;
    public NumArray(int[] nums) {
        this.preSums=new int[nums.Length];
        this.preSums[0]=nums[0];
        for(var x=1; x<nums.Length;++x){
            this.preSums[x]=this.preSums[x-1]+nums[x];
        }
    }
    
    public int SumRange(int left, int right) {
        if(left==0){
            return preSums[right];
        }else{
            return preSums[right]-preSums[left-1];
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end