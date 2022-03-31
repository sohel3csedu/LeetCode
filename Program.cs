// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        //int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
        //int[] nums = {-1,3,4,-5,9,-2};
        
        //int[] nums = {-5,-2,-4,-1};
        
        int[] nums = {5,4,-1,7,8};

        Console.WriteLine("53_Maximum_Subarray():Start "+MaxSubArray(nums));
    }
    
    //Divide and conquer
    public static int MaxSubArray(int[] nums){
        int arrayLength = nums.Length;
        return MaxSubArray(nums,0,arrayLength-1);
        
    }

    private static int MaxSubArray(int[] nums, int lowIndex, int hightIndex)
    {
        if(hightIndex == lowIndex) return nums[lowIndex];
        int midPoint = lowIndex+(hightIndex-lowIndex)/2;
        int leftSum = MaxSubArray(nums,lowIndex,midPoint);
        int rightSum = MaxSubArray(nums,midPoint+1,hightIndex);
        int corssSum = calcuateCrossSum(nums,lowIndex,hightIndex);
        return Math.Max(corssSum,Math.Max(leftSum,rightSum));
    }

    private static int calcuateCrossSum(int[] nums, int lowIndex, int hightIndex)
    {
        int leftMaxSum = int.MinValue;
        int leftCurrentSum = 0;
        int rightMaxSum = int.MinValue;
        int rightCurrentSum = 0;
        int midPoint = lowIndex+(hightIndex-lowIndex)/2;

        for(int i = midPoint; i >= lowIndex; i--){
            leftCurrentSum+= nums[i];
            leftMaxSum = Math.Max(leftCurrentSum,leftMaxSum);
        }
        for(int i = midPoint+1;i<=hightIndex;i++){
            rightCurrentSum+=nums[i];
            rightMaxSum = Math.Max(rightCurrentSum,rightMaxSum); 
        }
        return leftMaxSum+rightMaxSum;
    }
}