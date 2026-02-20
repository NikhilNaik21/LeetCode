using System;

public class Solution {
    public int MaxProfit(int[] prices) {

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            // Step 1: track lowest price
            if (price < minPrice)
                minPrice = price;

            // Step 2: calculate profit if sold today
            int profit = price - minPrice;

            // Step 3: update best profit
            if (profit > maxProfit)
                maxProfit = profit;
        }

        return maxProfit;
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
