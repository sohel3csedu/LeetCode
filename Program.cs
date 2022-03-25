// See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        string[] testString = {"flower","flow","flight"};
        //string[] testString = {"dog","racecar","car"};
        var sortedString = testString.OrderBy(a => a.Length).ToArray();
        string test = program.LongestCommonPrefix(sortedString);
        Console.WriteLine("longest substring :" +test);   
    }
    public string LongestCommonPrefix(string[] strs) {
        int longestMatch = 0;
        bool lengthOver200 = strs.Where(a => a.Length > 200).Any();
        if(lengthOver200){
            return string.Empty;
        }else
        {
            for(int i = 0; i < strs.Length; i++){
            for(int j = i + 1; j < strs.Length; j++){
                int currentMatch = GetLongestMatchNumberBetweenTwoString(strs[i],strs[i+1]);
                longestMatch = currentMatch;         
            }
        }
        
        return strs[0].Substring(0,longestMatch);    
        }
    }
    public int GetLongestMatchNumberBetweenTwoString(string s1, string s2){
        int longestMatchBetweenTheseTwo = 0;
        for(int k = 0; k < s1.Length; k++){
            char c1 = s1[k];
            char c2 = s2[k];
            if(c1 == c2)
                longestMatchBetweenTheseTwo++;
            else
                return longestMatchBetweenTheseTwo;
        }
        return longestMatchBetweenTheseTwo;
    }
}