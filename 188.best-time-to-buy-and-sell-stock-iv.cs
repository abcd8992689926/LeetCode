/*
 * @lc app=leetcode id=188 lang=csharp
 *
 * [188] Best Time to Buy and Sell Stock IV
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int k, int[] prices) {
        //在第i天,目前交易了j次,n是否持有股票
        int [,,] dp = new int[prices.Length+1,k,2];
        //在第1天,目前交易了0次,沒有持有股票,收益是0
        //在第1天,目前交易了1次,沒有持有股票,收益是0

        //在第1天,目前交易了0次,有持有股票

        //k = 2, prices = [3,2,6,5,0,3]

        //在第1天,目前交易了1次,持有股票，沒有動作
        //dp[1][1][1]-=prices[0];
        //在第1天,目前交易了1次,持有股票，賣出了股票
        //dp[1][1][0]=Int32.MinValue;

        //在第3天,目前交易了1次,沒有持有股票,目前最高收益
        //dp[3][1][0]=Math.Max(dp[2][1][0],dp[2][1][1]+prices[3]);

        //在第3天,目前交易了1次,持有股票,目前最高收益
        //dp[3][1][1]=Math.Max(dp[2][1][0]-prices[3],dp[2][1][1]);

        for(var i=0; i<prices.Length; i++){
            for(var j=0; j<k; j++){
                if(i==0){
                    dp[0,j,0]=0;
                    dp[0,j,1]=Int32.MinValue;
                }
                if(j==0){
                    dp[i,0,0]=0;
                    dp[i,0,1]=Int32.MinValue;
                }
                dp[i,j,0]=Math.Max(dp[i-1,j,0],dp[i-1,j,1]+prices[i]);
                dp[i,j,1]=Math.Max(dp[i-1,j,0]-prices[i],dp[i-1,j,1]);
            }
        }
        return dp[prices.Length,k-1,0];
    }
}
// @lc code=end

