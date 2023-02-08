/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 */

// @lc code=start
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount==0) return amount;
        Array.Sort(coins);
        int [] r=new int [amount+1];
        Array.Fill(r, amount+1);
        r[0]=0;
        foreach(var c in  coins){
            for(var x= c; x<amount+1; x++){
                if(c>amount) continue;
                r[x]=Math.Min(r[x-c]+1, r[x]);
            }
        }
        return r[amount]==amount+1?-1:r[amount];
    }
}
// @lc code=end

