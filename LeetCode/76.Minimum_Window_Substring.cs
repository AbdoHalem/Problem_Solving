//? Required Approach using Dictionary (Hash Table)
//* Time Complexity: O(|s| + |t|)
//* Space Complexity: O(1) - since the size of the ASCII character set is constant
//* But it is slow because of the dictionary operations
public class Solution {
    public string MinWindow(string s, string t)
    {
        // Return empty string if inputs are invalid or s is shorter than t
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
        {
            return "";
        }
        // Create a hashmap to count the occurences of each char in t
        Dictionary<char, int> t_CharCounter = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!t_CharCounter.ContainsKey(c))
            {
                t_CharCounter.Add(c, 1);
            }
            else
            {
                t_CharCounter[c]++;
            }
        }
        // Sliding Window Pattern
        int left = 0, right = 0;
        int num_char_included = 0;      // Number of chars of t included in the current window
        int required_chars = t.Length;  // Target number of characters to match
        // Track the minimum window
        int minLen = int.MaxValue;
        int minStart = 0;
        // Create a hashmap to count the occurences of required chars in the current window of s
        Dictionary<char, int> s_SubCounter = new Dictionary<char, int>();
        while (right < s.Length)
        {
            // Add current character to window's frequency map
            if (!s_SubCounter.ContainsKey(s[right]))
            {
                s_SubCounter.Add(s[right], 1);
            }
            else
            {
                s_SubCounter[s[right]]++;
            }
            // If the character is in 't' and its count doesn't exceed the required count, increment included chars
            if (t_CharCounter.ContainsKey(s[right]) && s_SubCounter[s[right]] <= t_CharCounter[s[right]])
            {
                num_char_included++;
            }
            // Shrink the window from the left as long as we have string t in this window
            while(num_char_included == required_chars)
            {
                int currentWindowLen = right - left + 1;
                if (currentWindowLen < minLen)
                {
                    minLen = currentWindowLen;
                    minStart = left;
                }
                // If removing leftChar breaks the valid window, decrement num_char_included
                if(t_CharCounter.ContainsKey(s[left]) && s_SubCounter[s[left]] <= t_CharCounter[s[left]])
                {
                    num_char_included--;
                }
                // Remove leftChar from the window's frequency map
                s_SubCounter[s[left]]--;
                // Shronk the current window from the left
                left++;
            }
            // Expand the window to the right
            right++;
        }
        // Return the minimum window substring or empty string if no valid window is found
        return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
    }
}

//^ Optimal Approach using ASCII Array
//* Time Complexity: O(|s| + |t|)
//* Space Complexity: O(1) - since the size of the ASCII character set is constant
//* But it is fast because of the array operations
public class Solution {
    public string MinWindow(string s, string t)
    {
        // Return empty string if inputs are invalid or s is shorter than t
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
        {
            return "";
        }
        // Use a single array instead of 2 Dictionaries for blazing fast ASCII lookups
        int[] charCounts = new int[128];
        // Add the requirements chars from string t
        foreach (char c in t)
        {
            charCounts[c]++;
        }

        // Sliding Window Pattern
        int left = 0, right = 0;
        int num_char_included = 0;      // Number of chars of t included in the current window
        int required_chars = t.Length;  // Target number of characters to match
        // Track the minimum window
        int minLen = int.MaxValue;
        int minStart = 0;
        // Create a hashmap to count the occurences of required chars in the current window of s
        Dictionary<char, int> s_SubCounter = new Dictionary<char, int>();
        while (right < s.Length)
        {
            // If the character is required (count > 0) --> we found one of the required chars
            if (charCounts[s[right]] > 0)
            {
                num_char_included++;
            }
            // Decrease the count (unneeded chars will become negative)
            charCounts[s[right]]--;

            // Shrink the window from the left as long as we have all the required chars in this window
            while(num_char_included == required_chars)
            {
                int currentWindowLen = right - left + 1;
                if (currentWindowLen < minLen)
                {
                    minLen = currentWindowLen;
                    minStart = left;
                }
                // Put the left character back into our counts
                charCounts[s[left]]++;

                // If it becomes > 0, it means we just removed a character we desperately needed
                if (charCounts[s[left]] > 0)
                {
                    num_char_included--;
                }
                // Shrink the current window from the left
                left++;
            }
            // Expand the window to the right
            right++;
        }
        // Return the minimum window substring or empty string if no valid window is found
        return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
    }
}