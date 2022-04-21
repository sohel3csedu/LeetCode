public class RemoveLinkedList{
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode dummyNode = new ListNode(){next = head};
        ListNode currentNode = head;    //scanner node
        ListNode previous = dummyNode;  //storing the previous value, which help to move the pointer while found match.
                
        while(currentNode != null){
            if(currentNode.val == val){
                previous.next = currentNode.next;
            }else{
                previous = currentNode;
            }
            currentNode = currentNode.next;    
        }

        return dummyNode.next;
    }
}