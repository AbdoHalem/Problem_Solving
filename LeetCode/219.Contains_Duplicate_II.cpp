#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

bool containsNearbyDuplicate(vector<int>& nums, int k) {
    bool res = false;
    unordered_map<int, int> seen;    //& To store indices of seen elements (key=number, value=index)
    int left = 0, right = 0;
    while(right < (int)nums.size()){
        if(seen.count(nums[right]) > 0){
            res = true;
            break;
        }
        seen[nums[right]] = right;
        right++;
        if(abs(right - left) > k){
            seen.erase(nums[left]);
            left++;
        }
    }
    return res;
}

int main(){
    vector<int> nums = {0,1,2,3,2,5};
    cout << containsNearbyDuplicate(nums, 3);
    return 0;
}