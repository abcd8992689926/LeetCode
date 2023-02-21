/*
 * @lc app=leetcode id=133 lang=csharp
 *
 * [133] Clone Graph
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node==null){
            return null;
        }
        
        var visted=new Dictionary<Node, Node>();
        var clone=new Node(node.val);
        visted.Add(node, clone);
        dfs(node, clone);
        
        return clone;
        void dfs(Node node, Node cloneNode){
            foreach(var x in node.neighbors){
                if(visted.ContainsKey(x)){
                    cloneNode.neighbors.Add(visted[x]);
                }else{
                    var c=new Node(x.val);
                    visted.Add(x,c);
                    cloneNode.neighbors.Add(c);
                    dfs(x,c);
                }
            }
        }
    }
}
// @lc code=end

