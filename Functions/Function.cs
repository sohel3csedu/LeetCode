
public class Functions{
    public int RemoveElement(int[] nums, int val) {
        
        int output = 0;
        for( int i =0; i < nums.Length ; i++ ){
            if(nums[i] != val){
                nums[output] = nums[i];
                output++;
            }
        }
        return output;
    }
}
