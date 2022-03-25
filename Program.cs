// See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        //string[] testString = {"flower","flow","flight","Flown"};
        //string[] testString = {"dog","racecar","car"};
        string[] testString = {"a"};
        var sortedString = testString.OrderBy(a => a.Length).ToArray();
        string test = program.LongestCommonPrefix(sortedString);
        Console.WriteLine("longest substring :" +test);   
    }
   
    public string LongestCommonPrefix(string[] strs) {
        
        if(strs.Length == 1 && string.IsNullOrEmpty(strs[0])) return "";
        else if(strs.Length == 1 && !string.IsNullOrEmpty(strs[0])) return strs[0];
        else{
              List<string> longestMatches = new List<string>();
                for(int i = 0; i < strs.Length; i++){
                    for(int j = i + 1; j < strs.Length; j++){
                        longestMatches.Add(commonPrefixUtil(strs[i],strs[j]));
                    }
                }
            return longestMatches.OrderBy(x => x.Length).FirstOrDefault();  
        }
    }
    public int GetLongestMatchNumberBetweenTwoString(string s1, string s2){
        int longestMatchBetweenTheseTwo = 0;
        //Dont know why there indexOut error getting
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
    static String commonPrefixUtil(String str1,String str2)
    {
        String result = "";
        int n1 = str1.Length,
            n2 = str2.Length;
 
        // Compare str1 and str2
        for (int i = 0, j = 0;
             i <= n1 - 1 && j <= n2 - 1;
             i++, j++)
        {
            if (str1[i] != str2[j])
            {
                break;
            }
            result += str1[i];
        }
        Console.WriteLine($"Matched part for string {str1} and {str2} is:  {result}");
        return (result);
    }
}