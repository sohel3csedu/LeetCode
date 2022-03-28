// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {1,1,1,2,2,3,4,5,5,6,6,7};

        Console.WriteLine("26_RemoveDuplicateFromAnSortedArray:Start "+RemoveDuplicates(nums));
    }
    public static int RemoveDuplicates(int[] nums) {
     int left_index = 1; 
     for(int right_index = 1; right_index < nums.Length; right_index++){
         if(nums[right_index] != nums[right_index-1]){
             nums[left_index] = nums[right_index];
             left_index++;
         }
     }
              
     return left_index;   
    }
//   public static int RemoveDuplicates(int[] nums) {
//      int i = 0; 
//      int j = 1;
            
//         while(j <= nums.Length - 1)
//         {
//                 if(nums[i] == nums[j])
//                 j++; //going to next element to check.
//             else
//                 nums[++i] = nums[j++];
//         }    
//      return ++i;   
//     }
    /*
    //Realizing differnt between ++i and i++ ;pre and post increment
    public static (int,int,int) testRetun(){
        int i = 4;
        int j = i++;
        int k = ++i;
        
        return (i,j,k);
    }
    */
}