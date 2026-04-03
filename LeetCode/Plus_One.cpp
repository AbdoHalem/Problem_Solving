#include <iostream>
#include <vector>
#include <math.h>

using namespace std;

vector<int> plusOne(vector<int>& digits) {
    int size = digits.size();
    if(digits[size-1] == 9){    // Last digit = 9
        if(size == 1){  // number is 9
            digits[size - 1] = 1;
            digits.push_back(0);
        }
        else{
            int i = size - 1; // Last index
            while(digits[i] == 9){
                if(i != 0){
                    digits[i] = 0;
                    i--;
                }
                else{
                    break;
                }
            }
            if(i == 0 && digits[i] == 9){
                digits[i] = 1;
                digits.push_back(0);
            }
            else{
                digits[i] += 1;
            }
        }
    }
    else{
        digits[size-1] += 1;
    }
    return digits;
}

int main(){
    vector<int> vec = {8, 9, 9, 9};
    vec = plusOne(vec);
    for(int i: vec){
        cout << i << endl;
    }
    return 0;
}