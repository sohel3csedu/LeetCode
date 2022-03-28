// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {3,2,2,3};

        Console.WriteLine("27_RemoveElement:Start "+RemoveElement(nums,1));
    }
    public static int RemoveElement(int[] nums, int val) {
        
        int output = 0;
        for( int i =0; i < nums.Length ; i++ ){
            if(nums[i] != val){
                nums[output] = nums[i];
                output++;
            }
        }
        return output;
    }
    /*
    //returning correct result here but don't know why it's causing and error on leetcode compiler.
    //I was not modifying the array elemments that's why it was returning error, it's little bit confusing, because
    //it said we need to return only the count but still it checks the array elements.
    public static int RemoveElement(int[] nums, int val) {
        int output = nums.Count();
        for(int i =0;i < nums.Count();i++){
           if(nums[i] == val)     
                output--;
        }
        return output;
    }
    */
}