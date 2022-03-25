// See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        string[] testString = {"Array","Of","String"};
        
        string test = program.LongestCommonPrefix(testString);
        Console.WriteLine(test);   
    }
    public string LongestCommonPrefix(string[] strs) {
        return "";
    }
}