public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public ListNode[] SplitListToParts(ListNode root, int k){
    ListNode[] res = new ListNode[k];
    int len = 0;
    ListNode p = root;
    while(p != null){
        len++;
        p = p.next;
    }
    p = root;
    int width = len / k;
    int remain = len % k;
    for(int i = 0; i < k; i++){
        ListNode head = p;
        for(int j = 0; j < width + (remain > i ? 1 : 0) - 1; j++){
            if(p != null){
                p = p.next;
            }
        }
        if(p != null){
            ListNode temp = p;
            p = p.next;
            temp.next = null;
        }
        res[i] = head;
    }
    return res;
}