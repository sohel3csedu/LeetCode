public class SingleNumber{
    public int singleNumber(int[] nums) {
        int output = 0;
        for(int i=0; i<nums.Length;i++){
            output = nums[i] ^ output;
        }
        // foreach(var num in nums){
        //     output^= num;
        // }
        
        return output;
    }
    // public bool isSet(int num){
    //     int F = 1;
    //     F = F << 4;
    //     int output = num & F;
    //     return F == output ? true: false;
    // }
    // public int numberOfBitSet(int num){
    //     int output=0;
    //     while(num > 0){
    //         if((num & 1) > 0)
    //             output++;
    //         num = num >> 1;
    //     }
    //     return output;
    // }
    // public int numberOfBitSet(int num){
    //     int output=0;
    //     while(num > 0){
    //         output++;
    //         num = num & (num-1);
    //     }
    //     return output;
    // }
}