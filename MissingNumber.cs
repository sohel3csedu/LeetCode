public class MissingNumber{
    public int getMissingNumber(int[] nums){
        
        for(int i = 1;i <= nums.Count();i++){
            if(!nums.Contains(i)){
                return i;
            }
        }
        return 0;
    }
}