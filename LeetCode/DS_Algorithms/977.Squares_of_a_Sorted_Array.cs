public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] res = new int[nums.Length];
        // Two Pointers Pattern to swap
        int left = 0, right = nums.Length - 1;
        int index = right;

        while(right >= left){
            if(nums[left] * nums[left] > nums[right] * nums[right]){
                res[index] = nums[left] * nums[left];
                left++;
            }
            else{
                res[index] = nums[right] * nums[right];
                right--;
            }
            index--;
        }
        return res;
    }
}