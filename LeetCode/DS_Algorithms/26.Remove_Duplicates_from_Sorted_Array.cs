public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Two Pointers (Fast & Slow) Pattern
        int left = 0, right  = 1;
        while(right < nums.Length){
            if(nums[left] == nums[right]){      // Duplicate
                right++;
            }
            else{
                left++;
                // Swap elements at index left and right using tuple deconstruction
                (nums[left], nums[right]) = (nums[right], nums[left]);
                right++;
            }
        }
        return left + 1;
    }
}