public class Stock{
    //in greedy algorithm try to think about how two pointer will be move.
    public int MaxProfit(int[] prices) {
        int buydayIndex = 0;
        int selldayIndex = 1;
        int MaxProfit = 0;
        while(selldayIndex<prices.Length){
            if(prices[buydayIndex]<prices[selldayIndex]){
                int currentProfit = prices[selldayIndex]-prices[buydayIndex];
                if(currentProfit > MaxProfit){
                    MaxProfit = currentProfit;
                }
            }else{
                buydayIndex=selldayIndex;   //directly update to the sellday index.
                //was failing test for int[] prices= {1,2,4,2,5,7,2,4,9,0,9};
            }
            selldayIndex++;
        }
        return MaxProfit;   
    }
}