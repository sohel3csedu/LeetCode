// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] nums = {4,1,2,1,2};
        // int[] nums = {4,3,2,7,8,2,3,1};
        SingleNumber _singleNumber = new SingleNumber();
        //_singleNumber.isSet(12);
        // var output = _singleNumber.singleNumber(nums);
        Console.WriteLine(_singleNumber.numberOfBitSet(7));
    }    

}