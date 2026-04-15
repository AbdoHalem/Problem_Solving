public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestSub = 0;
        // Sliding Window Pattern
        // Use an array to store the last seen index + 1 of each ASCII character
        int[] charIndex = new int[128]; 
        int left = 0;
        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            // If we have seen this character and it's inside our current window
            if (charIndex[currentChar] > left) {
                // Jump the left pointer directly after the previous occurrence
                left = charIndex[currentChar];
            }
            // Calculate current window length and update max
            int currentLength = right - left + 1;
            if (currentLength > longestSub) {
                longestSub = currentLength;
            }
            // Store the NEXT index to jump to if we see this character again
            charIndex[currentChar] = right + 1;
        }
        return longestSub;
    }
}