public class NumArray{
    public static int[] _nums;
    public  NumArray(int[] nums) {
        _nums = nums;
    }
    
    public int SumRange(int left, int right) {
        int sumRange = 0;
        while(left<=right){
            sumRange+= _nums[left];
            left++;
        }
        return sumRange;
    }
}