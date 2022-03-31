public static class LengthOfLastWord{
    public static void test(){
        Console.WriteLine("Console");
    }
    public static int lengthOfLastWord(string s) {
        int output=0;
        s = s.Trim();
        for(int i=s.Length-1;i>=0;i--){
            if(char.IsWhiteSpace(s[i])) break;
            else output++;
        }
        return output;
    }
}