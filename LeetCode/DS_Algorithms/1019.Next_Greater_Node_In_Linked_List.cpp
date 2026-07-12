/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
#include <vector>
using namespace std;

struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};
class Solution {
public:
    vector<int> nextLargerNodes(ListNode* head) {
        ListNode *temp = head;
        vector<int> values;
        while(temp != nullptr){
            values.push_back(temp->val);
            temp = temp->next;
        }
        temp = head;
        int size = values.size();
        vector<int> res(size, 0);
        vector<int> stack;
        for(int index = 0; index < size; index++){
            if(index == 0){stack.push_back(index);}
            else{
                while(stack.empty() == false){
                    if(values[index] > values[stack.back()]){
                        res[stack.back()] = values[index];
                        stack.pop_back();
                    }
                    else{
                        stack.push_back(index);
                        break;
                    }
                }
            }
            if(stack.empty()){stack.push_back(index);}
        }
        return res;
    }
};