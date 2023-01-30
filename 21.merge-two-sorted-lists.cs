/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null){
            return list2;
        }
        if(list2==null){
            return list1;
        }
        switch(list1.val<list2.val){
            case true:
                return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
            case false:
                return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
        }
    }
}
// @lc code=end

