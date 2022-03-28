
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
    public int StrStr(string haystack, string needle) {
        if(needle.Length == 0) return 0;
        
        for(int i =0; i < haystack.Length +1 - needle.Length;i++){
            for(int j = 0; j< needle.Length; j++){
                if(haystack[i+j] != needle[j]){
                    break;
                }
                if(j == needle.Length -1){
                    return i;
                }
            }
        }
        
        return -1;
    }
}
