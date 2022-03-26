// See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        int palindrome = 22222222;
        var test = palindrome.ToString().ToArray();
        bool isPalindrome = IsPalindrome(palindrome);
        Console.WriteLine("9_Palindrome:Start "+isPalindrome);   
    }

    private static bool IsPalindrome(int x)
    {
        int temp = x;
        int reversedNumber = 0;
        while(temp > 0){
            reversedNumber = temp % 10 + reversedNumber * 10;
            temp = temp /10;
        }
        return reversedNumber == x;
    }

}