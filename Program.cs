// See https://aka.ms/new-console-template for more information
public class Program{
    public static void Main(string[] args){
        Program program = new Program();
        int test = program.RomanToInt("LVIII");
        Console.WriteLine(test);   
    }
    public  int RomanToInt(string s){
        var romanAndIntMapping = new Dictionary<char, int>(){
	        {'I', 1},
	        {'V', 5},
	        {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int output = 0;
        for(int i =  0; i < s.Length; i++)
        {
            char currentChar = s.ElementAt(i);
            char nextChar = i == s.Length-1 ? s.ElementAt(i) : s.ElementAt(i+1);
             if(!romanAndIntMapping.ContainsKey(currentChar))
                return 0;
             else{
                    if(romanAndIntMapping[currentChar] < romanAndIntMapping[nextChar])
                        output-= romanAndIntMapping[currentChar];    
                    else
                        output+= romanAndIntMapping[currentChar];
             }
        }
        return output;
    }
}