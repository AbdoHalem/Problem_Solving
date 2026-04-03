class Solution {
public:
    int longestBalanced(vector<int>& nums) {
        unordered_map<int, int> evens;
        unordered_map<int, int> odds;    
        // sum -> first occurrence of this sum
        unordered_map<int, int> firstOccurrence;
        firstOccurrence[0] = 0; 
        int currentSum = 0;
        int maxLength = 0;

        for(int i = 1; i <= nums.size(); i++){
            if(nums[i-1] % 2 == 0){     // Even
                if(evens.count(nums[i-1]) == 0){
                    evens[nums[i-1]] = 1;   // Mark as seen
                    currentSum += 1;        // +1 for new distinct even
                }
                // else: +0 (Duplicates don't change the sum)
            }
            else{                 // Odd
                if(odds.count(nums[i-1]) == 0){
                    odds[nums[i-1]] = 1; // Mark as seen
                    currentSum -= 1; // -1 for new distinct odd
                }
                // else: +0
            }
            // Check if this sum happened before ?
            if(firstOccurrence.count(currentSum)){
                // This subarray is balanced
                maxLength = max(maxLength, i - firstOccurrence[currentSum]);
            }
            else{
                // Add it to the map
                firstOccurrence[currentSum] = i;
            }
        }
        if(evens.size() == 0 || odds.size() == 0){
            return 0;
        }  
        return maxLength;
    }
};