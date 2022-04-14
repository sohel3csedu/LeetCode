public class LinkedListCycle{
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> listNodes = new HashSet<ListNode>();
        
        while(head.next != null){
            if(listNodes.Contains(head))
                return true;
            listNodes.Add(head);
            head = head.next;
        }
        return false;   
    }
}
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 