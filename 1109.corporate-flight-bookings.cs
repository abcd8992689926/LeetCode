/*
 * @lc app=leetcode id=1109 lang=csharp
 *
 * [1109] Corporate Flight Bookings
 */

// @lc code=start
public class Solution {
    public int[] CorpFlightBookings(int[][] bookings, int n) {
        var diff=new int[n];
        diff[0]=0;
        for(var x=0; x<n; ++x){
            var i=bookings[x][0]-1;
            var j=bookings[x][1];
            var v=bookings[x][2];
            diff[i]+=v;
            diff[j]-=v;
        }
        var r=new int[n];
        r[0]=diff[0];
        for(var x=1;x<n;++x){
            r[1]=r[0]+diff[x];
        }
        return r;
    }
}
// @lc code=end