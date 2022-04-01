// See https://aka.ms/new-console-template for more information
using System.Collections;
public class Program{
    public static void Main(string[] args){
        Program program = new Program();

        //string _string = "   fly me   to   the moon  ";
        // int[] nums = {1,9,9,9};
        // Plus_One plus_One = new Plus_One();
        // plus_One.PlusOne(nums);
        // int[] P = {4,4,2,4};
        // int[] S = {5,5,2,5};
        // int[] P = {2,3,4,2};
        // int[] S = {2,5,7,2};
        
        //int[] S = {5,19,8,1};
        //Console.WriteLine(solution(S));
    }

/*
public static int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var _list = A.ToList();
        var _listSorted = _list.OrderByDescending(i => i);
        int totalEmission = _list.Sum(i => i);
        int targetEmission = totalEmission/2;
        int numberOfFilters=0;
        for(int j=0;j<_list.Count();j++){
            if(totalEmission - A[j] > 0 ){
                numberOfFilters++;
            }
        }
        return 3;
    }
*/
/*
public static int solution(int[] P, int[] S) {
        int numberOfExtraSeat = 0;
        int numberOfCars = S.Length;
        List<int> removedCarsIdx = new List<int>();
        for(int i = 0; i < P.Length; i++){
            if(P[i] == S[i] && numberOfExtraSeat == 0) continue;//do nothing
            else if(P[i] < S[i]) numberOfExtraSeat+= S[i]-P[i];
            else if((numberOfExtraSeat <=P[i]) || numberOfExtraSeat >= S[i]){
               numberOfCars--; 
               numberOfExtraSeat = numberOfExtraSeat-S[i];
               removedCarsIdx.Add(i);     
            }
        }
        if(numberOfExtraSeat > 0){
            for(int i = 0; i < P.Length;i++){
                if(!removedCarsIdx.Contains(i) && S[i] <= numberOfExtraSeat){
                    numberOfCars--;
                    numberOfExtraSeat = numberOfExtraSeat-S[i];
                    removedCarsIdx.Add(i);     
                }
            }
        }
        return numberOfCars;

    }
*/
    // public static string solution(string message, int K){
    //     int lastPositionGotSpace = 0;
    //     string output = string.Empty;
    //     if(K >= message.Length) return message;
    //     for(int i = 0; i<= K;i++){
    //         if(char.IsWhiteSpace(message[i]))
    //             lastPositionGotSpace = i;
    //     }
    //     output = message.Substring(0,lastPositionGotSpace).Trim();
    //     return output;
    // }
    
}