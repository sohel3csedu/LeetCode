// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {9,6,4,2,3,5,7,0,8};
        MissingNumber missingNumber = new MissingNumber();
        var output = missingNumber.getMissingNumber(nums);
        Console.WriteLine(output);
    }    

}