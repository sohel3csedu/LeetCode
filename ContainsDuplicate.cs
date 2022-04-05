public class ContainsDuplicate{
    public bool containsDuplicate(int[] nums){
        List<int> distinctNumbers = new List<int>();
        for(int i = 0;i < nums.Length;i++){
            if(distinctNumbers.Contains(nums[i]))
                return true;
            else
                distinctNumbers.Add(nums[i]);
        }
        return false;
    }
}