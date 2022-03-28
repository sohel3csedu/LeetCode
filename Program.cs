// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        Console.WriteLine("28_ImplementStrStr():Start "+StrStr("","al"));
    }
   public static int StrStr(string haystack, string needle) {
        if(needle.Length == 0) return 0;
        
        for(int i =0; i < haystack.Length +1 - needle.Length;i++){
            for(int j = 0; j< needle.Length; j++){
                if(haystack[i+j] != needle[j]){
                    break;
                }
                if(j == needle.Length -1){
                    return i;
                }
            }
        }
        
        return -1;
    }

}