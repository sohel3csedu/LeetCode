public class Add_Binary{
    public string AddBinary(string a, string b) {
        string output = string.Empty;
        var reversed_a = a.Reverse().ToArray();
        var reversed_b = b.Reverse().ToArray();
        int carryOn = 0;
        int maximumLengthOfString = Math.Max(a.Length,b.Length);
        for(int j = 0;j<maximumLengthOfString;j++){
            int DigitA = 0;
            int DigitB = 0;
            if(j < a.Length) DigitA = Int32.Parse(reversed_a[j].ToString());
            if(j < b.Length) DigitB = Int32.Parse(reversed_b[j].ToString());
            
            int currentChar = (DigitA+DigitB+carryOn)%2;
            carryOn = (DigitA+DigitB+carryOn)/2;
            output = currentChar.ToString()+output;
        }
        if(carryOn == 1) output = "1"+output;
        return output;      
    }
}