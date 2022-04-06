public class FindDisappeared{
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> output = new List<int>();
        for(int i = 1;i <= nums.Count();i++){
            if(!nums.Contains(i)){
                output.Add(i);
            }
        }
        return output;
    }
}