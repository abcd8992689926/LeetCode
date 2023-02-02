/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {        
        var res = new List<IList<int>>();
        var rs = new List<int>();
        res.Add(rs);
        foreach(var x in nums){  
            rs = new List<int>();
            rs.Add()
            var tmp=new List<int>();
            foreach(var xx in res){
                tmp.Add(xx+x);
            }
            
            rs.AddRange(tmp);
            res.Add(rs);
            rs = new List<int>();
        }
        return res;
    }
}
// @lc code=end

