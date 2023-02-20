/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid==null || grid.Length==0 || grid[0].Length==0){
            return 0;
        }
        
        var visited=new bool[grid.Length,grid[0].Length];
        var currentLand=0;
        var bottom=grid.Length-1;
        var right=grid[0].Length-1;

        for(var x=0; x<grid.Length; ++x){
            for(var xx=0; xx<grid[x].Length; ++xx){
                if(visited[x,xx]==true){
                    continue;
                }
                
                if(grid[x][xx]=='1'){
                    currentLand++;
                    DFS(x, xx);
                }
                visited[x,xx]=true;
            }
        }
        
        void DFS(int x, int xx){
            if(x<0 || xx<0 || x>bottom || xx>right || visited[x,xx]==true || grid[x][xx]=='0'){
                return;
            }
            
            visited[x,xx]=true;
            
            DFS(x-1, xx);
            DFS(x+1, xx);
            DFS(x, xx-1);
            DFS(x, xx+1);
        }

        return currentLand;
    }
}
// @lc code=end

