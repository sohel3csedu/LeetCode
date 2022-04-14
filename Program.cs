// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        MiddleOfLinkedList middleOfLinkedList =  new MiddleOfLinkedList();
        Node headNode = new Node(10);
        Console.WriteLine("Summation is::"+middleOfLinkedList.MiddleNode(headNode).val);
    }    

}