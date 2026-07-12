public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLength = 0;
        // Sliding window pattern (dynamic window size)
        int[] freqArray = new int[26]; // Frequency array
        int left = 0;
        int maxFreq = 0;
        for(int right = 0; right < s.Length; right++){
            // 1. Add the new char to the window's frequency array
            int rightChar = s[right] - 'A';
            freqArray[rightChar]++;
            // 2. Check the highest frequency
            if(freqArray[rightChar] > maxFreq){
                maxFreq = freqArray[rightChar];
            }
            // 3. Validate the length of the window
            while((right - left + 1) - maxFreq > k){
                int leftChar = s[left] - 'A';
                freqArray[leftChar]--;
                left++;
            }
            // 4. Check max window length
            if(right - left + 1 > maxLength){
                maxLength = right - left + 1;
            }
        }
        return maxLength;
    }
}