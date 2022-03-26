    // See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        string inputValue = "({}){}";
        bool isPalindrome = IsValid(inputValue);
        Console.WriteLine("9_Palindrome:Start "+isPalindrome);   
    }

    public static bool IsValid(string s) {
        char[] openBrac = {'(','{','['};
        char[] closeBrac = {')','}',']'};
        for(int i=0,j = i+1;i < s.Length-1; i++,j++){
            int Openidx = Array.IndexOf(openBrac,s[i]);
            int Closeidx = Array.IndexOf(closeBrac,s[j]);
            if(Openidx != Closeidx)
                return false;
        }
        return true;
    }

}