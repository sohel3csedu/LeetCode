// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {1,1,1,3,3,4,3,2,4,2};
        ContainsDuplicate containsDuplicate = new ContainsDuplicate();
        var output = containsDuplicate.containsDuplicate(nums);
        Console.WriteLine(output);
    }    

}