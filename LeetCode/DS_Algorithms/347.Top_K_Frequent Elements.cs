public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];     // To store the result
        if(res.Length > 0){
            // Create a hashmap to store fequencies of each number
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                if(freqMap.ContainsKey(nums[i])){
                    freqMap[nums[i]] += 1;
                }
                else{
                    freqMap.Add(nums[i], 1);
                }
            }
            // Create a bucket to save the numbers with same frequency at the same list
            // Index => Frequency
            List<int>[] bucket = new List<int>[nums.Length + 1];
            foreach(var item in freqMap){
                int number = item.Key;
                int freq = item.Value;
                if(bucket[freq] == null){
                    bucket[freq] = new List<int>();
                }
                bucket[freq].Add(number);
            }

            int targetCount = 0;
            for(int i = bucket.Length - 1; i > 0 && targetCount < k; i--){
                if(bucket[i] == null)  continue;
                foreach(var number in bucket[i]){
                    res[targetCount] = number;
                    targetCount++;
                }
            }
        }
        return res;
    }
}