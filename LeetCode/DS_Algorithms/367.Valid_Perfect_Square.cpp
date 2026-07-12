class Solution {
public:
    // int binarySearch(vector<int> &arr, int left, int right, int num){
    //     int mid = (left + right)/2;
    //     if(left == right){
    //         if(arr[left] == num){return num;}
    //         else{
    //             return -1;
    //         }
    //     }
    //     if(num > mid){
    //         binarySearch(arr, mid+1, right, num);
    //     }

    // }

    bool isPerfectSquare(int num) {
        bool res = false;
        if(num == 1){res = true; return res;}
        // vector<int> arr;
        // for(int i = 2; i <= num/2; i++){
        //     arr.push_back(i);
        // }
        // // Binary Search

        // ====================================
        for(long i = 1; i*i <= num; i++){
            if(i*i == num){
                res = true;
                break;
            }
        }
        return res;
    }
};