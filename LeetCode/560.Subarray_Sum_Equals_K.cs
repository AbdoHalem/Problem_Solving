public class Solution {
    public int SubarraySum(int[] nums, int k) {
        // Prefix Sum Algorithm
        int res = 0;
        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>() { { 0, 1 } };   // To store the count of each prefix sum
        // Calculate the prefix sums
        int currentSum = 0;
        foreach (int num in nums)
        {
            currentSum += num;
            int PrefixSumOld = currentSum - k;
            // Check if we passed over the number prefixSum that we want to subtract
            if (prefixSumCount.ContainsKey(PrefixSumOld))
            {
                res += prefixSumCount[PrefixSumOld];
            }
            if(!prefixSumCount.ContainsKey(currentSum))
            {
                prefixSumCount[currentSum] = 1;
            }
            else
            {
                prefixSumCount[currentSum]++;
            }
        }
        return res;
    }
}