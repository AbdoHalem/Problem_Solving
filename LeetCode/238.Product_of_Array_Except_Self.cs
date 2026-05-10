//* My first approach
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        // Prefix Sum algorithm nut using multiplication not summation
        int[] prefixProd = new int[nums.Length];
        int[] suffixProd = new int[nums.Length];
        prefixProd[0] = suffixProd[nums.Length - 1] = 1;
        
        // Array to calculate prefix and suffix products
        int len = nums.Length;
        for(int i = 1; i < nums.Length; i++){
            prefixProd[i] = prefixProd[i-1] * nums[i-1];
            suffixProd[len - i - 1] = suffixProd[len - i] * nums[len - i];
        }
        for(int i = 0; i < answer.Length; i++){
            answer[i] = prefixProd[i] * suffixProd[i];
        }
        return answer;
    }
}

//* Optimal approach
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        // Prefix Sum algorithm but using multiplication not summation
        // 1. Calculate the prefix products and store them directly in answer
        answer[0] = 1;
        for(int i = 1; i < answer.Length; i++){
            answer[i] = answer[i-1] * nums[i-1];
        }

        // 2. Calculate the suffix product in a variable and multiply it into answer
        int suffixProd = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            answer[i] = answer[i] * suffixProd;
            suffixProd *= nums[i];
        }
        return answer;
    }
}