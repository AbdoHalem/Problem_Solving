class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        // Sliding window pattern using hash map
        int index1 = 0, index2 = 0;
        unordered_map<char, int> hash;
        int length = 0, maxLength = 0;
        for(index2 = 0; index2 < s.size(); index2++){
            if(hash.count(s[index2]) != 0){
                // Make index1 points to the element after duplicated element
                int i = index1;
                index1 = hash[s[index2]] + 1;
                // Remove elements before the duplicate character
                for(; i < hash[s[index2]]; i++){
                    hash.erase(s[i]);
                }
            }
            else{
                length = index2 - index1 + 1;
            }
            // Add the current element to the hash after deleting its duplicate
            hash[s[index2]] = index2;
            // Update the length of the longest length
            maxLength = length > maxLength ? length : maxLength;
        }
        return maxLength;
    }
};