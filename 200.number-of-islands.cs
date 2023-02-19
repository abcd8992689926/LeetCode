/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    public bool [] visited=new bool[grid.Length];
    public int NumIslands(char[][] grid) {
        if(grid==null || grid.Length==0 || grid[0].Length==0){
            return 0;
        }
        
        Array.Fill(visited, false);

        foreach(var v in visited){
            if(v==true){
                continue;
            }
            DFS(v, grid);
        }
    }
    public void DFS(int c, char[] grid){
        if(visited[c]==true){
            return;
        }
        visited[c]=true;

        foreach(var x in grid){
            DFS(x, grid);
        }
    }
}
// @lc code=end

