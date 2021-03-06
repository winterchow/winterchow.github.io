public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
    if(l1 == null){
        return l2;
    }
    if(l2 == null){
        return l1;
    }
    ListNode dummy = new ListNode(0);
    ListNode p = dummy;
    while(l1 != null && l2 != null){
        if(l1.val > l2.val){
            p.next = l2;
            p = p.next;
            l2 = l2.next;
        }
        else{
            p.next = l1;
            p = p.next;
            l1 = l1.next;
        }
    }
    while(l1 != null){
        p.next = l1;
        p = p.next;
        l1 = l1.next;
    }
    while(l2 != null){
        p.next = l2;
        p = p.next;
        l2 = l2.next;
    }

    return dummy.next;
}