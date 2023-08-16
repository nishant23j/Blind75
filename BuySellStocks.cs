public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int buyPrice = prices[0];
        for(int i = 1; i<prices.Length; i++)
        {
            if(buyPrice > prices[i])
            {
                buyPrice = prices[i];
            }
            else if(prices[i] - buyPrice > profit)
            {
                profit = prices[i] - buyPrice;
            }
        }
        return profit;
    }
}