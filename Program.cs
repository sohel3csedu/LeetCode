﻿// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        
        int[] nums = {-1,0,3,5,9,12};
        //int target = 5;
        //BinarySearch _binarySearch = new BinarySearch();
        Square _square = new Square();
        Console.WriteLine("index is::"+_square.SortedSquares(nums).ToString());
        
    }    

}