public class MiddleOfLinkedList{
    public Node MiddleNode(Node head) {
        if(head == null)    return null;
        Node fasterNode = head;
        Node slowerNode = head;
        while(fasterNode != null && fasterNode.next != null){
            fasterNode = fasterNode.next.next;
            slowerNode = slowerNode.next;
        }
        return slowerNode;
    }
}
 public  class Node {
      public int val;
      public Node next;
      public Node(int val=0, Node next=null) {
          this.val = val;
          this.next = next;
      }
  }