/*
 * @lc app=leetcode id=1943 lang=csharp
 *
 * [1943] Describe the Painting
 */

// @lc code=start
public class Solution {
    public IList<IList<long>> SplitPainting(int[][] segments) {
        var r = new List<IList<long>>();
        var d = new Dictionary<long,long>();
        var s=0L;
        var p=0L;
        for(var x=0; x<segments.Length; ++x){
            var i=segments[x][0];
            var j=segments[x][1];
            var v=segments[x][2];
            if(!d.ContainsKey(i)){
                d.Add(i,0L);
            }
            d[i]+=v;
            if(!d.ContainsKey(j)){
                d.Add(j,0L);
            }
            d[j]-=v;
        }
        foreach(var x in d){
            if(s>0){
                r.Add(new List<long>{p, x.Key, s});
            }
            s+=x.Value;
            p=x.Key;
        }
        return r;
    }
}
// @lc code=end

