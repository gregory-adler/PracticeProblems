namespace Library {
    using System;
    using System.Collections.Generic;
      public class StockMarketTiming{
        public int maxProfit(int[] prices){
            if (prices.Length <=1){
                return 0;
            }
            int[,] start = {{0,0}};
            int[,] current = {{0,0}};
            int[,] next = {{0,0}};
            int max = 0;
            List<int> buymarkers = new List<int>();
            List<int> sellmarkers = new List<int>();
            Boolean alreadyBought = false;
            Boolean firstSale = false;
            Boolean alreadyRising = false;
            int lastrising = 0;
            
            for (int i = 0; i< prices.Length; i++){
                if (i == 0) {
                    buymarkers.Add(i);
                    alreadyBought = true;
                }
                current[0,0] = i;
                current[0,1] = prices[i];
                if (i+1 >= prices.Length){
                    if (current[0,1] > prices[i-1] && alreadyBought){
                        sellmarkers.Add(i);
                    }
                    else if (alreadyRising) {
                        sellmarkers.Add(lastrising);
                    }
                    else{
                    }
                    break;
                }
                next[0,0] = i+1;
                next[0,1] = prices[i+1];
                if (next[0,1] < current[0,1]){
                    if (firstSale == false){
                        buymarkers[0] = next[0,0];
                        continue;
                    }
                    if (alreadyBought) {
                        sellmarkers.Add(current[0,0]);
                        alreadyBought = false;
                        firstSale = true;
                        alreadyRising = false;
                    }
                }
                if (next[0,1] > current[0,1]){
                    firstSale = true;
                    alreadyRising = true;
                    lastrising = i+1;
                    if (alreadyBought){
                        continue;
                    }
                    else {
                        buymarkers.Add(current[0,0]);
                        alreadyBought = true;
                    }
                }
            }

            for (int i = 0; i<= sellmarkers.Count-1; i++) {
                max += prices[sellmarkers[i]] - prices[buymarkers[i]];
            }
            return max;
        }
      }
}