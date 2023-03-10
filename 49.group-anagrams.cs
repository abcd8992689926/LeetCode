/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var d=new Dictionary<string,List<string>>();
        var rs=new List<IList<string>>();
        for(var x=0; x<strs.Length; ++x){
            var val=strs[x].ToCharArray();
            Array.Sort(val);
            var tmp=new string(val);
            if(d.ContainsKey(tmp)){
                d[tmp].Add(strs[x]);
            }else{
                d.Add(tmp, new List<string>{strs[x]});
            }
        }
        foreach(var x in d){
            rs.Add(x.Value);
        }
        return rs;
    }
}
// @lc code=end

