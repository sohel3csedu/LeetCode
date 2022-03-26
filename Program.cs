// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        string inputValue = "{}()";
        bool isPalindrome = IsValid(inputValue);
        Console.WriteLine("20_Valid parentheses:Start "+isPalindrome);   
    }
//stack:first in last out
    /*
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
    */
    public static bool IsValid(string s){
        Dictionary<char,char> bracMaps= new Dictionary<char, char>(){
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        //create a stack
        Stack stack = new Stack();
        for(int i = 0; i < s.Length ; i++){
           char c = s[i];
           if(bracMaps.Keys.Contains(c)){
               //if its an open bracket then we push into stack, otherwise pop
                stack.Push(c);
           }else{
                if(stack.Count > 0){
                    //we go the last element of the stack and pop it.
                    char top = (char)stack.Pop();
                    //top of stack is '['
                    //current element is ']'
                    
                    // var test1 = s[i];
                    // var test2 = bracMaps[top]; //pair of current element
                    //if pair of top element of stack != current element then returning false
                    if(s[i] != bracMaps[top]){
                        return false;
                    }    
                }else{
                        return false;
                    }
           }
        }
        if(stack.Count > 0) return false;
           else return true;
    }

}