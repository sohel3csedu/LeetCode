public class PalindromeLinkedList{
    public bool IsPalindrome(ListNode head) {
        ListNode fastPointer = head;
        ListNode slowPointer = head;
        while(fastPointer != null && fastPointer.next != null){
            Console.WriteLine();
            fastPointer = fastPointer.next.next;
            slowPointer = slowPointer.next;
        }
        //after traversing slowpointer should be midpoint.
        ListNode mid = slowPointer;
        ListNode reversedLastHalf = ReverseList(mid);
        
        //now compare whether it's palindrome or not
        ListNode left = head;
        ListNode right = reversedLastHalf;
        while(right != null){
            if(left.val != right.val)
                return false;
            left = left.next;
            right = right.next;    
        }
        return true;   
    }
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        while(current != null){
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }