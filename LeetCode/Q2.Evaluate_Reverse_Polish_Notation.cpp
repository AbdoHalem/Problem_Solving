class Solution {
public:
    int evaluateEquation(int num1, int num2, string operation){
        if(operation == "+"){return num1 + num2;}
        else if(operation == "-"){return num1 - num2;}
        else if(operation == "*"){return num1 * num2;}
        else if(operation == "/"){return num1 / num2;}
        else{return 0;}
    }
    int evalRPN(vector<string>& tokens) {
        vector<int> resStack;
        int i = 0;
        while(i < tokens.size()){
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i]=="/"){
                string operation = tokens[i]; 
                int num2 = resStack.back(); resStack.pop_back();
                int num1 = resStack.back(); resStack.pop_back();
                resStack.push_back(evaluateEquation(num1, num2, operation));
                i++;
            }
            else{
                resStack.push_back(stoi(tokens[i++]));
            }
        }
        return (resStack[0]);
    }
};