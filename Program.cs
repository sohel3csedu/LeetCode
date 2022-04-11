// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int[] prices= {7,6,4,3,15};
        // int[] prices= {7,1,5,3,6,4};
        Stock _stock = new Stock();
        
        Console.WriteLine("Max profit is::"+_stock.MaxProfit(prices));
    }    

}