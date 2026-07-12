class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> hashNums;
        for(int i = 0; i < nums.size(); i++){
            int num1 = target - nums[i];
            if(hashNums.find(num1) != hashNums.end()){
                return {i, hashNums[num1]};
            }
            else{
                hashNums[nums[i]] = i;
            }
        }
        return {};
    }
};