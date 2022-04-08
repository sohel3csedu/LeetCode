public class ClimbingStairs{
    /*
    public int ClimbStairs(int n) {
        int oneStepValue = 1;
        int twoStepValue = 1;
        for(int i = 0;i<n-1;i++){
            int temp = oneStepValue;
            oneStepValue = oneStepValue+twoStepValue;
            twoStepValue = temp;
        }
        return oneStepValue;
    }
    */
    //solving recursive way
    /*
    public int ClimbStairs(int n) {
        if(n == 0 || n == 1) return 1;
        else
            return ClimbStairs(n-1)+ClimbStairs(n-2);
    }
    */
    //some bottom up solution
    public int ClimbStairs(int n) {
        int[] nums = new int[n+1];
        if(n == 1 || n == 0) return 0;
        nums[0] = 1;
        nums[1] = 1;
        for(int i = 2;i<=n;i++){
            nums[i] = nums[i-1]+nums[i-2];
        }
        return nums[n];
    }
}