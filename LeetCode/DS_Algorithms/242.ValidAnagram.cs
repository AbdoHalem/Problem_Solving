public class Solution {
    public bool IsAnagram(string s, string t) {
        bool res = true;
        if(s.Length != t.Length){
            res = false;
        }
        else{
            // Frequency array pattern
            int[] counts = new int[26];
            for(int i = 0; i < s.Length; i++){
                counts[s[i] - 'a']++;
                counts[t[i] - 'a']--;
            }
            foreach(var c in counts){
                if(c != 0){
                    res = false;
                    break;
                }
            }
        }
        return res;
    }
}