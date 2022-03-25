// See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        // int[] nums = {2,7,11,15};
        // int target = 9;
        int[] nums = {0,4,3,0};
        int target = 0;
        // int[] nums = {3,2,4};
        // int target = 6;
        // int[] nums = {3,3};
        // int target = 6;
        // int[] nums = {-1,4,-3,7};
        // int target = -4;
        var res = TwoSum(nums,target);
        Console.WriteLine("1_Two:Start "+res);   
    }

    public static int[] TwoSum(int[] nums, int target) {
        int[] position = new int[2];
        for(int i = 0; i < nums.Length; i++){
           for(int j = i+1;j<nums.Length;j++ ){
                if(nums[i]+nums[j] == target){
                   position[0] = i;
                   position[1] = j;
                }
            }   
        }
        return position;
    }
}