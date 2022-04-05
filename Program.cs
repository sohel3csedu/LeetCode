// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        Add_Binary add_Binary = new Add_Binary();
        ContainsDuplicate containsDuplicate = new ContainsDuplicate();
        var output = containsDuplicate.containsDuplicate();
    }    

}