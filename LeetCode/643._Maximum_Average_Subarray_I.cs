public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int maxSum = 0;
        // Sliding window pattern (fixed window size)
        int currentSum = 0;
        for(int i = 0; i < k; i++){
            currentSum += nums[i];
        }
        maxSum = currentSum;
        // Loop over the array by moving the window 1 step to the right
        for(int right = k; right < nums.Length; right++){
            currentSum += nums[right] - nums[right - k];
            if(currentSum > maxSum){
                maxSum = currentSum;
            }
        }
        return (double)maxSum / k;
    }
}