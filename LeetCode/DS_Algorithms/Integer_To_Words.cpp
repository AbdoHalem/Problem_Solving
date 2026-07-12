#include <iostream>
#include <string>
using namespace std;

// Static arrays are built once and stay in memory - Much faster than maps
const string belowTwenty[20] = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
const string tens[10] = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
const string thousands[4] = {"", "Thousand", "Million", "Billion"};

string helper(int num) {
    if (num == 0) return "";
    else if (num < 20) return belowTwenty[num] + " ";
    else if (num < 100) return tens[num / 10] + " " + helper(num % 10);
    else return belowTwenty[num / 100] + " Hundred " + helper(num % 100);
}
string numberToWords(int num) {
    if (num == 0) return "Zero";
    
    string res = "";
    int i = 0;
    
    while (num > 0) {
        if (num % 1000 != 0) {
            res = helper(num % 1000) + thousands[i] + " " + res;
        }
        num /= 1000;
        i++;
    }
    // Trim trailing spaces
    while (res.back() == ' ') res.pop_back();
    return res;
}


int main(){
    cout << numberToWords(1234567);
    return 0;
}