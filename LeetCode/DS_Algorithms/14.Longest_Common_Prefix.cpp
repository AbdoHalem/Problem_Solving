#include <iostream>
#include <vector>
using namespace std;

// string longestCommonPrefix(vector<string>& strs) {
//     if (strs.empty()) return "";
//     string res = strs[0];
    
//     for (int i = 1; i < strs.size(); i++) {
//         // Optimization: The prefix can't be longer than the current string
//         if (res.length() > strs[i].length()) {
//             res = res.substr(0, strs[i].length());
//         }
//         // Compare characters
//         for (int j = 0; j < res.length(); j++) {
//             if (res[j] != strs[i][j]) {
//                 // Mismatch found, cut the prefix at this point and break
//                 res = res.substr(0, j);
//                 break;
//             }
//         }
//     }
//     return res;
// }

string longestCommonPrefix(vector<string>& strs) {
    if (strs.empty()) return "";
    string res = strs[0];
    
    for (int i = 1; i < strs.size(); i++) {
        while (strs[i].find(res) != 0) {
            res.pop_back(); // Remove last char
            // If res becomes empty, no common prefix
            if (res.empty()) return "";
        }
    }
    return res;
}

int main(){
    vector<string> strs = {"flower","flow","flight"};
    cout << longestCommonPrefix(strs);
    return 0;
}

// class Solution {
// public:
//     string longestCommonPrefix(vector<string>& strs) {
//         if(strs.size() == 1){return strs[0];}
//         // string first = strs[0];
//         // string res = "";
//         string res = strs[0];

//         for(int i = 1; i < strs.size(); i++){
//             for(int j = 0; j < strs[i].length(); j++){
//                 // if(first.length() <= strs[i].length()){
//                 if(j < res.length() && j < strs[i].length()){
//                     if(res[j] == strs[i][j]){
//                         // res.push_back(first[j]);
//                     }
//                     else{
//                         if(res.empty() != 1){
//                             res.pop_back();
//                         }
//                         // break;
//                     }
//                 }
//             }
//         }
//         return res;
//     }
// };