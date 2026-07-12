#include <iostream>
#include <vector>
#include <algorithm>
#include <unordered_map>
using namespace std;

class Solution {
public:
    vector<int> findErrorNums(vector<int>& nums) {
        vector<int> res;
        unordered_map<int, int> map;
        int sum = 0, total = 0;
        for(int i = 1; i <= nums.size(); i++){total += i;}
        for(int i : nums){
            sum += i;
            if(map.count(i) == 1){
                res.push_back(i);
                sum -= i;
            }
            else{
                map[i] = i;
            }
        }
        res.push_back(total - sum); 
        return res;
    }
};

int main(){
    return 0;
}
