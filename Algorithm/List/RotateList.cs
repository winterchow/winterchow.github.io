public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
public ListNode RotateRight(ListNode head, int k){
    if(head == null){
        return head;
    }
    ListNode dummy = new ListNode(0);
    dummy.next = head;
    int len = 0;
    ListNode l1 = dummy, l2 = dummy;
    while(l1.next != null){
        len++;
        l1 = l1.next;
    }
    for(int i = len - k % len; i > 0; i--){
        l2 = l2.next;
    }
    l1.next = dummy.next;
    dummy.next = l2.next;
    l2.next = null;

    return dummy.next;
}