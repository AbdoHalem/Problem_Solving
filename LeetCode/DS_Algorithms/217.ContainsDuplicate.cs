public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        bool res = false;
        HashSet<int> hashValues = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(hashValues.Contains(nums[i])){
                res = true;
                break;
            }
            else{
                hashValues.Add(nums[i]);
            }
        }
        return res;
    }
}