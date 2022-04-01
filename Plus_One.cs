public class Plus_One{
    
    public int[] PlusOne(int[] digits) {
        string output = string.Empty;
        var test = digits.ToList();
        int addOne = 1;
        List<int> testOutput = new List<int>();
        int[] returnValue = new int[4];
        for(int i = digits.Length-1;i >=0;i--){
            if(digits[i] == 9){
                testOutput.Add(0);
            }else{
                testOutput.Add(digits[i]+addOne);
                addOne = 0;
            }
        }

        if(addOne == 1 && testOutput.Count() == digits.Count())
        {
            testOutput.Add(addOne);
            addOne = 0;
        }
        // int j=0;
        // for(int i = testOutput.Count() - 1;i >=0;i--){
        //     returnValue[j] = testOutput[i];
        //     j++;
        // }

        var test_ = testOutput.ToArray().Reverse();
        
        // for(int i=0;i < digits.Length; i++){
        //     output += digits[i];
        // }
        // int output1 = int.Parse(output)+1;
        // output = output1.ToString();
        // var output2 = output.ToArray();
        // int j = 0;
        // foreach(char ch in output){
        //     returnValue[j] = int.Parse(ch);
        //     j++;
        // }
        // for( int i = 0; i < output.Length;i++){
        //     returnValue[i] = 0;//int.Parse(output2[i]);
        // }
        //output = output1.ToString();
        return new int[10];
    }
}