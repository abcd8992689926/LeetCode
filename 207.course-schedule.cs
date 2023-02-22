/*
 * @lc app=leetcode id=207 lang=csharp
 *
 * [207] Course Schedule
 */

// @lc code=start
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // 建立有向圖的鄰接表
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }

        // 初始化入度表
        int[] inDegree = new int[numCourses];

        // 填充鄰接表和入度表
        for (int i = 0; i < prerequisites.Length; i++) {
            int u = prerequisites[i][0];
            int v = prerequisites[i][1];
            graph[v].Add(u);
            inDegree[u]++;
        }

        // 用 Queue 存儲入度為 0 的節點
        Queue<int> q = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (inDegree[i] == 0) {
                q.Enqueue(i);
            }
        }

        // 當 Queue 非空時，不斷從 Queue 中取出節點，將該節點的出邊刪除，相應地更新入度表，
        // 如果出現入度為 0 的新節點，將其加入 Queue 中。
        while (q.Count > 0) {
            int u = q.Dequeue();
            for (int i = 0; i < graph[u].Count; i++) {
                int v = graph[u][i];
                inDegree[v]--;
                if (inDegree[v] == 0) {
                    q.Enqueue(v);
                }
            }
        }

        // 判斷是否存在入度不為 0 的節點
        for (int i = 0; i < numCourses; i++) {
            if (inDegree[i] != 0) {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

