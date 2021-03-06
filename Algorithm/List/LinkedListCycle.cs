public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public bool HasCycle(ListNode head) {
    if(head == null){
        return false;
    }
    ListNode slow = head;
    ListNode fast = head;
    while(fast.next != null && fast.next.next != null){
        slow = slow.next;
        fast = fast.next.next;
        if(slow.val == fast.val){
            return true;
        }
    }

    return false;
}