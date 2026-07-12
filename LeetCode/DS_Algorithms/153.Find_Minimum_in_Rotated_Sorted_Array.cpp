class Solution {
public:
    int findMin(vector<int>& nums) {
        // Apply Binary Search Algorithm
        int start = 0, end = nums.size() - 1;
        int mid = 0;
        while(start <= end){
            mid = (start + end) / 2;
            if(nums[mid] < nums[end]){
                end = mid;
            }
            else{
                start = mid + 1;
            }
        }
        return nums[mid];
    }
};