public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

// 1, 2, -3, 3, 1
public ListNode RemoveZeroSumSublists(ListNode head) {
    ListNode dummy = new ListNode(0);
    dummy.next = head;
    ListNode cur = dummy;
    int sum = 0;
    Dictionary<int, ListNode> preSum = new Dictionary<int, ListNode>();
    while(cur != null){
        sum += cur.val;
        if(preSum.ContainsKey(sum)){
            cur = preSum[sum].next;
            int p = sum + cur.val;
            while(p != sum){
                preSum.Remove(p);
                cur = cur.next;
                p += cur.val;
            }
            preSum[sum].next = cur.next;
        }
        else{
            preSum.Add(sum, cur);
        }

        cur = cur.next;
    }

    return dummy.next;
}