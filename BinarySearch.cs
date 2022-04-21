public class BinarySearch{
    public int Search(int[] nums, int target) {
        return Binary_Search(0,nums.Length-1,nums,target);
    }
    public int Binary_Search(int left,int right,int[] nums,int target){
        if(left > right) return -1;
        int mid = left + (right-left)/2;
        if(nums[mid] == target) {return mid;}
        if(target < nums[mid]){
            return Binary_Search(left,mid-1,nums,target);
        }
        else
            return Binary_Search(mid+1,right,nums,target);
    }
}