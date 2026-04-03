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
        if(list1 == null) return list2;
        else if(list2 == null) return list1;
        ListNode resHeader = new ListNode(-1);  // Dummy node
        ListNode resList = resHeader;           // Traversing node
        while(list1 != null && list2 != null){
            if(list2.val < list1.val){
                resList.next = list2;
                list2 = list2.next;
            }
            else{
                resList.next = list1;
                list1 = list1.next;
            }
            resList = resList.next;
        }
        if(list1 == null){
            resList.next = list2;
        }
        else{
            resList.next = list1;
        }
        return resHeader.next;
    }
}