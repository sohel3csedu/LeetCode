// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {3,2,2,3};

        Console.WriteLine("27_RemoveElement:Start "+RemoveElement(nums,3));
    }
    public static int RemoveElement(int[] nums, int val) {
        int output = nums.Count();
        for(int i =0;i < nums.Count();i++){
           if(nums[i] == val)     
                output--;
        }
        return output;
    }
}