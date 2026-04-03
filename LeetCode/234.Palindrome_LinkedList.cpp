#include <iostream>

using namespace std;
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

struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

//? Stack Solution */
// class Solution {
// public:
//     bool isPalindrome(ListNode* head) {
//         int res = 1;
//         ListNode* tail = head;
//         vector<int> stack = {};
//         while(tail != nullptr){
//             stack.push_back(tail->val);
//             tail = tail->next;
//         }
//         while(head != nullptr){
//             if(head->val == stack.back()){
//                 head = head->next;
//                 stack.pop_back();
//             }
//             else{
//                 res = 0;
//                 break;
//             }
//         }
//         return res;
//     }
// };

//? O(n) time and O(1) space Solution
bool isPalindrome(ListNode* head) {
    bool res = true;
    ListNode *pSlow = head;
    ListNode *pFast = head;
    //* Get the middle node
    while(pFast != nullptr && pFast->next != nullptr){
        pSlow = pSlow->next;
        pFast = pFast->next->next;
    }
    //* Reverse the second half of the list
    ListNode *pPrev = nullptr;
    ListNode *pCurr = pSlow;
    while(pCurr != nullptr){
        ListNode *pNextTemp = pCurr->next;
        pCurr->next = pPrev;
        pPrev = pCurr;
        pCurr = pNextTemp;
    }
    //& Now, pPrev is the head of the second reversed half
    ListNode *pFirsrHalf = head;
    ListNode *pSecondHalf = pPrev;
    while(pSecondHalf != nullptr){
        if(pFirsrHalf->val == pSecondHalf->val){
            pFirsrHalf = pFirsrHalf->next;
            pSecondHalf = pSecondHalf->next;
        }
        else{
            res = false;
            break;
        }
    }
    //* Return the second half of the list to its original state
    pCurr = pPrev;
    pPrev = nullptr;
    while(pCurr != nullptr){
        ListNode *pNextTemp = pCurr->next;
        pCurr->next = pPrev;
        pPrev = pCurr;
        pCurr = pNextTemp;
    }
    return res;
};

int main(){
    ListNode *head = new ListNode(1);
    head->next = new ListNode(2);
    head->next->next = new ListNode(2);
    head->next->next->next = new ListNode(1);
    cout << isPalindrome(head) << endl;
    //& Check the list is recovered successfully
    cout << head->val << head->next->val << head->next->next->val << head->next->next->next->val;
    return 0;
}