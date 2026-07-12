class Solution {
public:
    int divide(int dividend, int divisor) {
        int res = 0;
        if(dividend > INT_MAX){return INT_MAX;}
        else if(dividend < -INT_MAX-1){return -INT_MAX-1;}
        int sign = 1;
        if(dividend * divisor < 0){
            sign = -1;
        }
        while(dividend >= abs(divisor)){
            dividend -= abs(divisor);
            res++;
        }
        return res * sign;
    }
};