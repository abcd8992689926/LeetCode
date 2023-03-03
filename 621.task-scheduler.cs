/*
 * @lc app=leetcode id=621 lang=csharp
 *
 * [621] Task Scheduler
 */

// @lc code=start
public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if(n==0){
            return tasks.Length;
        }
        int[] count=new int[26];
        for(var x=0; x<tasks.Length; ++x){
            count[tasks[x]-'A']++;
        }
        Array.Sort(count);
        int max=0;
        for(var x=0; x<count.Length; ++x){
            if(count[x]==count[25]){
                max++;
            }
        }
        return Math.Max(tasks.Length, (count[25]-1)*(n+1)+max);
    }
}
// @lc code=end