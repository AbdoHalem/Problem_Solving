public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // Dictionary to save the sorted words => keys, original words => values
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            // Sort the characters of the current string to use it as a key
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);
            // If this sorted word hasn't been seen before, create a new list for it
            if(!anagrams.ContainsKey(sortedWord)){
                anagrams.Add(sortedWord, new List<string>());
            }
            // Add the ORIGINAL word to the correct anagram list
            anagrams[sortedWord].Add(strs[i]);
        }
        return anagrams.Values.Cast<IList<string>>().ToList();
    }
}