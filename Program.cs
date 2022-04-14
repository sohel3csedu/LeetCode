// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        LinkedListCycle obj = new LinkedListCycle();
        ListNode listNode = new ListNode(10);
        Console.WriteLine("Summation is::"+obj.HasCycle(listNode));
    }    

}