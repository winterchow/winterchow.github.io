public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
public bool IsPalindrome(ListNode head) {
    ListNode fast = head;
    ListNode slow = head;
    while(fast != null && fast.next != null){
        slow = slow.next;
        fast = fast.next.next;
    }
    ListNode reverse = Reverse(slow);
    while(reverse != null){
        if(reverse.val != head.val){
            return false;
        }
        reverse = reverse.next;
        head = head.next;
    }

    return true;
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