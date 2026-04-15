public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        // Sliding Window Pattern
        int left = 0, right = 1;
        while(right < prices.Length && right > left){
            if(prices[right] < prices[left]){   // Can buy at day(right) because it has less price
                left = right;
            }
            else{
                if(profit < prices[right] - prices[left]){
                    profit = prices[right] - prices[left];
                }
            }
            right++;                
        }
        return profit;
    }
}