// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
        
        // int[] nums = {1};
        
        // int[] nums = {5,4,-1,7,8};

        Console.WriteLine("53_Maximum_Subarray():Start "+MaxSubArray(nums));
    }
    public static int MaxSubArray(int[] nums) {
        
        if(nums.Length == 1 ) return nums[0];
        if(nums.Length == 0 ) return 0;
        int midPoint = (nums.Length)/2;
        int leftMaxSum = getLeftMaxSum(nums,0,midPoint);
        int rightMaxSum = getRightMaxSum(nums,midPoint,nums.Length-1);
        int maxLeftRight = Math.Max(leftMaxSum,rightMaxSum);
        int result = Math.Max(maxLeftRight,leftMaxSum+rightMaxSum);
        return result;
    }
    private static int getRightMaxSum(int[] nums, int startIndex, int lastPoint)
    {
        int rightMaxSum = int.MinValue;
        int sum = 0;
        for(int l = startIndex;l <= lastPoint; l++){
            sum = sum+ nums[l];
            if(sum > rightMaxSum){
                rightMaxSum = sum;
            }
        }
        return rightMaxSum;
    }
    public static int getLeftMaxSum(int[] nums,int startIndex, int midPoint){
        int leftMaxSum = int.MinValue;
        int sum = 0;
        for(int l = startIndex;l<midPoint;l++){
            sum+=nums[l];
            if(sum > leftMaxSum){
               leftMaxSum = sum;     
            }
        }
        return leftMaxSum;
    }
}