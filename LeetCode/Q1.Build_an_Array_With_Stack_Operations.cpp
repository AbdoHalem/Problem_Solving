#include <iostream>
#include <vector>
#include <numeric>
using namespace std;


vector<string> buildArray(vector<int>& target, int n) {
    vector<string> res = {};
    for(int i = 1, j = 0; i <= n && j < target.size(); i++){
        res.push_back("Push");
        if(i == target[j]){
            j++;
        }
        else{
            res.push_back("Pop");
        }
    }
    return res;
}