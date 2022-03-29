// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
        
        // int[] nums = {1};
        
        // int[] nums = {5,4,-1,7,8};

        Console.WriteLine("53_Maximum_Subarray():Start ");
    }
    public static int MaxSubArray(int[] nums) {
        
        return 0;
    }
    public int calculateMaxSubArray(int[] nums, int i, int j){
        if(i == j ) return nums[i];
        int midPoint = (i+j)/2;
        int leftMaxSum = getLeftMaxSum(nums,i,j,midPoint);
        int rightMaxSum = int.MaxValue;
        

    }
    public int getLeftMaxSum(int[] nums,int i, int j, int midPoint){
        int leftMaxSum = int.MinValue;
        int sum = 0;
        for(int l = i;l<=midPoint;l++){
            sum+=nums[l];
            if(sum > leftMaxSum)
                leftMaxSum = sum;
        }
    }
}