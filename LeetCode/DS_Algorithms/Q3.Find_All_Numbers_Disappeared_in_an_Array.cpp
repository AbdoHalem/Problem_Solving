class Solution {
public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
        vector<int> res;
        vector<int> numbers(nums.size(), 0);
        for(int i: nums){
            numbers[i-1] = i;
        }
        for(int i = 0; i < nums.size(); i++){
            if(numbers[i] == 0){
                res.push_back(i+1);
            } 
        }
        return res;
    }
};