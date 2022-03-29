
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
    public static int SearchInsert(int[] nums, int target) {
       
       int position = binarySearchRecursive(nums,target,0,nums.Length -1);
        if(position == -1){
            for(int i = 0; i < nums.Length; i++){
                if(target > nums[nums.Length -1]){
                    return nums.Length;
                }
                else if(target  < nums[i]){
                    return i;
                }
        }
       }
       
       return position;
    }
    public static int binarySearchRecursive(int[]nums, int target,int left,int right ){
        if(left > right){
            return -1;
        }
        int midPoint = (left + right) / 2;
        if(nums[midPoint] == target){
            return midPoint;
        }else if(target < nums[midPoint]){
            return binarySearchRecursive(nums,target,left,midPoint-1);
        }else{
            return binarySearchRecursive(nums,target,midPoint+1,right);
        }
    }
}
