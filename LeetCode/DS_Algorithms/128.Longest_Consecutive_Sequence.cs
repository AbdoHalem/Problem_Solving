public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        int longestSeq = 0;                 // Save the longest seqence
        HashSet<int> uniqueNums = new HashSet<int>(nums); // Create a hash set to store unique numbers

        foreach(var num in uniqueNums){
            // Check if the current num is a start of sequence or not
            if(uniqueNums.Contains(num - 1)){   
                continue;       // It is not a start ==> skip
            }
            int nextNum = num + 1;
            int currentSeq = 1;
            while(uniqueNums.Contains(nextNum)){
                nextNum++;
                currentSeq++;
            }
            if(currentSeq > longestSeq) {
                longestSeq = currentSeq;
            }
        }
        return longestSeq;
    }
}