public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public ListNode Reverse(ListNode head){
    ListNode cur = head;
    ListNode pre = null;
    while(cur != null){
        ListNode temp = cur.next;
        cur.next = pre;
        pre = cur;
        cur = temp;
    }

    return pre;
}