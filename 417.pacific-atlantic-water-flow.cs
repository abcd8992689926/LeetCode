/*
 * @lc app=leetcode id=417 lang=csharp
 *
 * [417] Pacific Atlantic Water Flow
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] matrix) {
        var res = new List<IList<int>>();
        if(matrix==null || matrix.Length==0){
            return res;
        }
        int m = matrix.Length;
        int n = matrix[0].Length;
        var pacific = new bool[m,n];
        var atlantic = new bool[m,n];

        for(var x=0; x<m; ++x){
            dfs(x,0,pacific,matrix[x][0]);
            dfs(x,n-1,atlantic,matrix[x][n-1]);
        }
        for(var xx=0; xx<n; ++xx){
            dfs(0,xx,pacific,matrix[0][xx]);
            dfs(m-1,xx,atlantic,matrix[m-1][xx]);
        }

        for(var x=0; x<m; ++x){
            for(var xx=0; xx<n; ++xx){
                if(pacific[x,xx]&&atlantic[x,xx]){
                    res.Add(new List<int>(){x,xx});
                }
            }
        }

        return res; 
        void dfs(int x, int xx, bool[,] visted, int preheight){
            if(x<0||x>=m||xx<0||xx>=n||visted[x,xx]||matrix[x][xx]<preheight){
                return;
            }
            visted[x,xx]=true;
            dfs(x-1,xx,visted,matrix[x][xx]);
            dfs(x+1,xx,visted,matrix[x][xx]);
            dfs(x,xx-1,visted,matrix[x][xx]);
            dfs(x,xx+1,visted,matrix[x][xx]);
        }
    }
}
// @lc code=end

