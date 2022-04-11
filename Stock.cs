public class Stock{
    public int MaxProfit(int[] prices) {
        int buydayIndex = 0;
        int MaxProfit = 0;
        while(buydayIndex<prices.Length){
            for(int selldayIndex = buydayIndex+1;selldayIndex < prices.Length;selldayIndex++){
                int CurrentProfit = prices[selldayIndex]-prices[buydayIndex];
                if(CurrentProfit > MaxProfit)
                    MaxProfit = CurrentProfit;
            }
            buydayIndex++;
        }
        return MaxProfit;   
    }
}