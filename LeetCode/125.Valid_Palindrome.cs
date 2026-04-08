using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        bool res = true;
        // Use two pointers pattern to check palindrome
        int right = s.Length - 1;
        int left = 0;
        while(left < right){
            while(left < right && !char.IsLetterOrDigit(s[left])){
                left++;
            }
            while(left < right && !char.IsLetterOrDigit(s[right])){
                right--;
            }
            if(char.ToLower(s[left]) != char.ToLower(s[right])){
                res = false; break;
            }
            left++; right--;
        }
        return res;
    }
}