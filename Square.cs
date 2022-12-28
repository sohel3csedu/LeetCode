public class Square{
    public int[] SortedSquares(int[] nums) {
        if(nums.Length > 0)
            for(int i = 0; i< nums.Length; i++){
                nums[i] = nums[i]*nums[i];
            }
            Array.Sort(nums);
        return nums;
    }
}