// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        string a = "1010";
        string b = "1011";
        Add_Binary add_Binary = new Add_Binary();
        var output = add_Binary.AddBinary(a,b);
    }    

}