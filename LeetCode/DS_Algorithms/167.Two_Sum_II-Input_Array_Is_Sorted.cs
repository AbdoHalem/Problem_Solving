public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int left = 0, right = numbers.Length - 1;
        // Use two pointers pattern
        while(res[0] == res[1]){
            // Check whether to decrease right num or increase left num depending on their sum
            if(numbers[left] + numbers[right] > target){
                right--;
            }
            else if(numbers[left] + numbers[right] < target){
                left++;
            }
            else{
                res[0] = left + 1;
                res[1] = right + 1;
            }
        }
        return res;
    }
}