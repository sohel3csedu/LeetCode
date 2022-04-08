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
    public int ClimbStairs(int n) {
        if(n == 0 || n == 1) return 1;
        else
            return ClimbStairs(n-1)+ClimbStairs(n-2);
    }
}