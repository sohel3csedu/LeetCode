public class LinkedListCycle{
    /*
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        HashSet<ListNode> listNodes = new HashSet<ListNode>();
        
        while(head.next != null){
            if(listNodes.Contains(head))
                return true;
            listNodes.Add(head);
            head = head.next;
        }
        return false;   
    }
    */
    public bool HasCycle(ListNode head){
        ListNode fastpointer = head;
        ListNode slowpointer = head;
        while(fastpointer!= null && fastpointer.next != null){  //why not slow pointer checking? may be fastpointer reaches earlier
            fastpointer = fastpointer.next.next;
            slowpointer = slowpointer.next;
            if(fastpointer == slowpointer)
                return true;
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
 