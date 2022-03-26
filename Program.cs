// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();

        ListNode list1 = new ListNode(1);
        list1.val = 2;
        list1.val = 4;
        //Console.WriteLine("21_Merge_Two sorted list:Start "+MergeTwoLists(list1,list2));   
    }
   public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        ListNode newHeadNode = new ListNode();
        ListNode scannerNode = new ListNode();
        scannerNode = newHeadNode;

        while(list1 != null && list2 != null){
           if(list1.val >= list2.val){
                scannerNode.next = list2;
                list2 = list2.next;
           }else{
               scannerNode.next = list1;
               list1 = list1.next;
           }
           scannerNode = scannerNode.next;
        }
        if (list2 != null) scannerNode.next = list2;
        if (list1 != null) scannerNode.next = list1;
        return newHeadNode.next;
    } 
/*
Could not debug and check the values by own eye
newHead is just a pointer, and runnerHead does the real work. runnerHead adds things to newHead via that pointer, so the end result is a blank node with the entire solution starting at newHead.next
*/
 
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next = null) {
         this.val = val;
         this.next = next;
     }
 }

}