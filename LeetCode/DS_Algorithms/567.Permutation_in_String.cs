//? My first Approach
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        bool res = false;
        // Sliding Window Pattern (Fixed Window)
        int left = 0, right = 0; 
        int requiredSum = 0;
        foreach(char c in s1){
            requiredSum += (int)c;
        }
        int windowSum = 0;
        while(right < s2.Length){
            if(right - left + 1 < s1.Length){
                windowSum += (int)s2[right++];
            }
            else{
                if(windowSum == requiredSum){
                    res = true; break;
                }
                right++;
                windowSum += (int)(s2[right] - s2[left]);
                left++;
            }
        }
        return res;
    }
}

//? Optimal Approach
//* Time Complexity: O(n)
//* Space Complexity: O(1)

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        // Sliding Window pattern (fixed window size)
        // Use frequency arrays of size 26 since it's only lowercase English letters
        int[] s1_freq = new int[26];
        int[] window_freq = new int[26];

        // 1. Initialize the first window
        for (int i = 0; i < s1.Length; i++) {
            s1_freq[s1[i] - 'a']++;
            window_freq[s2[i] - 'a']++;
        }
        // 2. Calculate the initial number of exact matching frequencies
        int matches = 0;
        for (int i = 0; i < 26; i++) {
            if (s1_freq[i] == window_freq[i]) {
                matches++;
            }
        }

        // 3. Slide the window one character at a time
        int left = 0;
        for (int right = s1.Length; right < s2.Length; right++) {
            // If all 26 characters have the same frequency, we found a permutation!
            if (matches == 26) return true;

            // Add the new character from the right
            int rightChar = s2[right] - 'a';
            window_freq[rightChar]++;
            // Update matches based on the new character
            if (window_freq[rightChar] == s1_freq[rightChar]) {
                matches++;
            } else if (window_freq[rightChar] == s1_freq[rightChar] + 1) {
                matches--;
            }

            // Remove the old character from the left
            int leftChar = s2[left] - 'a';
            window_freq[leftChar]--;
            // Update matches based on the removed character
            if (window_freq[leftChar] == s1_freq[leftChar]) {
                matches++;
            } else if (window_freq[leftChar] == s1_freq[leftChar] - 1) {
                matches--;
            }
            left++;
        }
        return matches == 26;
    }
}