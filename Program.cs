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
    
    // static int[] MaxSubArray_Helper(int[] nums, int start, int end) {
    //     if (start == end) return new int[] { start, end, nums[start] }; /* Base case for recursion */
        
	// 	/* Divide step */
    //     int mid = start + ((end - start) / 2);
		
	// 	/* Conquer step */
    //     int[] left = MaxSubArray_Helper(nums, start, mid);
    //     int[] right = MaxSubArray_Helper(nums, mid + 1, end);
    //     int[] current = GetSubArraySum(nums, start, mid, end);
        
	// 	/* Combine step */
    //     if (current[2] > left[2] && current[2] > right[2]) return current;
    //     else if (left[2] > right[2]) return left;
    //     else return right;
    // }
    // static int[] GetSubArraySum(int[] nums, int start, int mid, int end) {
    //     int i = mid, leftSum = 0, maxLeftSum = int.MinValue;
    //     while (i >= start) {
    //         leftSum += nums[i--];
    //         maxLeftSum = Math.Max(maxLeftSum, leftSum);
    //     }
        
    //     int j = mid + 1, rightSum = 0, maxRightSum = int.MinValue;
    //     while (j <= end) {
    //         rightSum += nums[j++];
    //         maxRightSum = Math.Max(maxRightSum, rightSum);
    //     }
        
	// 	/* Combine sum as max-sum at left plus max-sum at right */
    //     return new int[] { i, j, maxLeftSum + maxRightSum };
    // }
    // public static int MaxSubArray(int[] nums) {
    //     if (nums.Length == 0) return 0;
    //     int[] result = MaxSubArray_Helper(nums, 0, nums.Length -1);
    //     return result[2];
    // }

    /*
    public static int MaxSubArray(int[] nums) {
        
        if(nums.Length == 1 ) return nums[0];
        if(nums.Length == 0 ) return 0;
        
        int midPoint = 0 + ((nums.Length -1) / 2);
        int leftMaxSum = getLeftMaxSum(nums,midPoint,0);
        int rightMaxSum = getRightMaxSum(nums,midPoint+1,nums.Length-1);
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
    public static int getLeftMaxSum(int[] nums,int startIndex, int endIndex){
        int leftMaxSum = int.MinValue;
        int sum = 0;
        for(int l = startIndex;l >= endIndex;l--){
            sum+=nums[l];
            if(sum > leftMaxSum){
               leftMaxSum = sum;     
            }
        }
        return leftMaxSum;
    }
    
    public static int getMaxSumOfASubarray(int[] nums){
        int maxSubArray = nums[0];
        int currentSum = 0;
        for(int i = 0; i < nums.Length - 1; i++){
            if(currentSum < 0){
                currentSum = 0;
            }
            currentSum+=nums[i];
            maxSubArray = Math.Max(maxSubArray,currentSum);
        }
        return maxSubArray;
    }
    */
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