/*
 * @lc app=leetcode id=207 lang=csharp
 *
 * [207] Course Schedule
 */

// @lc code=start
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int [] inDegree=new int[numCourses];
        List<int>[] graph=new List<int>[numCourses];
        Queue<int> q=new Queue<int>();

        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }
        
        foreach(var x in prerequisites){
            int u=x[0];
            int v=x[1];
            graph[v].Add(u);
            inDegree[u]++;
        }

        for(var x=0; x<numCourses; ++x){
            if(inDegree[x]==0){
                q.Enqueue(x);
            }
        }

        while(q.Count>0){
            var w=q.Dequeue();
            foreach(var x in graph[w]){
                inDegree[x]--;
                if(inDegree[x]==0){
                    q.Enqueue(x);
                }
            }
        }

        foreach(var x in inDegree){
            if(x!=0) return false;
        }

        return true;
    }
}
// @lc code=end

