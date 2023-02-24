/*
 * @lc app=leetcode id=210 lang=csharp
 *
 * [210] Course Schedule II
 */

// @lc code=start
public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int>[] graph=new List<int>[numCourses];
        List<int> output=new List<int>();
        int[] inDegree=new int[numCourses];
        Queue<int> q= new Queue<int>();

        for(var x=0; x<numCourses; ++x){
            graph[x]=new List<int>();
        }

        for(var x=0; x<prerequisites.Length; ++x){
            int u=prerequisites[x][0];
            int v=prerequisites[x][1];
            graph[v].Add(u);
            inDegree[u]++;
        }

        for(var x=0; x<numCourses; ++x){
            if(inDegree[x]==0){
                q.Enqueue(x);
            }
        }

        while(q.Count>0){
            for(var x=0; x<q.Count; ++x){
                int c=q.Dequeue();
                output.Add(c);
                
                for(var xx=0; xx<graph[c].Count; ++xx){
                    int v=graph[c][xx];
                    inDegree[v]--;
                    if(inDegree[v]==0){
                        q.Enqueue(v);
                    }
                }
            }
        }

        for(var x=0; x<numCourses; ++x){
            if(inDegree[x]!=0){
                return new int[0];
            }
        }

        return output.ToArray();
    }
}
// @lc code=end

