using System;

public class Solution {
    public int MaxProfit(int[] prices) {
       int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
        
            for (int j = i + 1; j < prices.Length; j++)
            {
                int currentProfit = prices[j] - prices[i];

                if( currentProfit > profit)
                {
                    profit = currentProfit;
                }    

            }
        }
        return profit;

    }
}



------ optimized version -------

using System;

public class Solution {
    public int MaxProfit(int[] prices) {

       int minPrice = int.MaxValue; 
       int maxProfit = 0;

        foreach(var price in prices)
        {
            if(price < minPrice)
            {
                minPrice = price;    
            }

            int profit = price - minPrice;

            if(profit > maxProfit){
                maxProfit = profit;
            }
        }
        return maxProfit;

    }
}
