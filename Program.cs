// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {4,3,2,7,8,2,3,1};
        FindDisappeared _findDisappeared = new FindDisappeared();
        var output = _findDisappeared.FindDisappearedNumbers(nums);
        Console.WriteLine(output);
    }    

}