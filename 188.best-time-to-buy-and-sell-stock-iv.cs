/*
 * @lc app=leetcode id=188 lang=csharp
 *
 * [188] Best Time to Buy and Sell Stock IV
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int k, int[] prices) {
        //在第i天,目前交易了j次,n是否持有股票
        int [] dp = new int[prices.Length][k][2];
        //在第1天,目前交易了0次,沒有持有股票,收益是0
        //在第1天,目前交易了1次,沒有持有股票,收益是0

        //在第1天,目前交易了0次,有持有股票
        Array.Fill(dp, Int32.MinValue);
        dp[0][0][0]=0;
        //k = 2, prices = [3,2,6,5,0,3]

        //在第1天,目前交易了1次,持有股票，沒有動作
        dp[1][1][1]-=prices[0];
        //在第1天,目前交易了1次,持有股票，賣出了股票
        dp[1][1][0]=Int32.MinValue;

        //在第2天,目前交易了0次,沒有持有股票
        dp[2][0][0]=0;
        //在第2天,目前交易了1次,持有股票
        dp[2][0][1]-=prices[0];

        //在第2天,目前交易了1次,持有股票，沒有動作
        dp[2][1][1]=0;
        //在第2天,目前交易了1次,持有股票，賣出了股票
        dp[2][1][1]+=prices[0];
    }
}
// @lc code=end

