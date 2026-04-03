#include <iostream>
#include <vector>

using namespace std;

vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
    // 1. Frequency Array (Constraints say numbers are up to 100)
    vector<int> count(101, 0); // 101 just to be safe with indices  
    // Step 1: Count occurrences
    for (int num : nums) {
        count[num]++;
    }
    // Step 2: Compute cumulative sum
    for (int i = 1; i <= 100; i++) {
        count[i] += count[i-1];
    }
    // Step 3: Build result
    vector<int> res(nums.size());
    for (int i = 0; i < (int)nums.size(); i++) {
        if (nums[i] == 0) {
            res[i] = 0;
        } else {
            res[i] = count[nums[i] - 1];
        }
    }
    return res;
}

int main(){
    vector<int> nums = {8,1,2,2,3};
    for(int i : smallerNumbersThanCurrent(nums)){cout << i << " ";}
    return 0;
}