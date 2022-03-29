// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {1,3,5,6};
        int target = 7;

        // int[] nums = {1,3,5,6,8,10,12};
        // int target = 15;
        
        // int[] nums = {1,3,5,6};
        // int target = 5;

        Console.WriteLine("35_Implement_SearchInsert():Start "+SearchInsert(nums,target));
    }
   public static int SearchInsert(int[] nums, int target) {
       
       int position = binarySearchRecursive(nums,target,0,nums.Length -1);
        if(position == -1){
            for(int i = 0; i < nums.Length; i++){
                if(target > nums[nums.Length -1]){
                    return nums.Length;
                }
                else if(target  < nums[i]){
                    return i;
                }
        }
       }
       
       return position;
    }
    public static int binarySearchRecursive(int[]nums, int target,int left,int right ){
        if(left > right){
            return -1;
        }
        int midPoint = (left + right) / 2;
        if(nums[midPoint] == target){
            return midPoint;
        }else if(target < nums[midPoint]){
            return binarySearchRecursive(nums,target,left,midPoint-1);
        }else{
            return binarySearchRecursive(nums,target,midPoint+1,right);
        }
    }
}