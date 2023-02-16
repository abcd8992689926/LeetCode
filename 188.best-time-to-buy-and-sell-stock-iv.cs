/*
 * @lc app=leetcode id=188 lang=csharp
 *
 * [188] Best Time to Buy and Sell Stock IV
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int [,,] dp = new int[prices.Length,k,2];
        for(var i=0; i<prices.Length; i++){
            for(var j=0; j<k; j++){
                dp[i,j,1]=Int32.MinValue;
            }
        }
        for(var i=0; i<prices.Length; i++){
            for(var j=1; j<k; j++){
                if (i == 0) {
                    dp[i,j,1] = -prices[0];
                    dp[i,j,0] = 0;
                    continue;
                }
                dp[i,j,0]=Math.Max(dp[i-1,j,0],dp[i-1,j,1]+prices[i]);
                dp[i,j,1]=Math.Max(dp[i-1,j-1,0]-prices[i],dp[i-1,j,1]);
            }
        }
        return dp[prices.Length-1,k-1,0];
    }
}
// @lc code=end

