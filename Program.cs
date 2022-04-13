// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        int[] nums= {-2, 0, 3, -5, 2, -1};
        NumArray numArray = new NumArray(nums);
        
        Console.WriteLine("Summation is::"+numArray.SumRange(0,5));
    }    

}