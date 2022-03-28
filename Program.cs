// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        Console.WriteLine("28_ImplementStrStr():Start "+StrStr("healo","al"));
    }
   public static int StrStr(string haystack, string needle) {
        int needleIdx = 0;
        if(needle.Length == 0) return 0;
        while(needleIdx < needle.Length){
            for(int i = 0; i < haystack.Length; i++){
                if(needle[needleIdx] == haystack[i]){
                    
                }
            }
        }
        for(int i = 0; i < needle.Length ; i++){
            for(int j = 0; j < haystack.Length; j++){
                if(needle[i] == haystack[j]){
                    needleIdx = j;
                }else{
                    needleIdx = 0;
                }
            }    
        }
        return needleIdx;
    }

}