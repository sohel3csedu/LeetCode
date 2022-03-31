public static class MaxSubArray{
    public static int MaxSubArrayCalc(int[] nums) {
        
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
    /*
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
}