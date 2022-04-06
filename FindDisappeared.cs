public class FindDisappeared{
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> output = new List<int>();
        for(int i = 0;i < nums.Count();i++){
            int newIdx = Math.Abs(nums[i])-1;
            int newValue = -1*Math.Abs(nums[newIdx]);   //updating the existing array with - only, not changing the values there.
            nums[newIdx] = newValue;
        }
        for(int i = 0;i < nums.Length;i++){
            if(nums[i] > 0)
                output.Add(i+1);
        }
        return output;
    }
}