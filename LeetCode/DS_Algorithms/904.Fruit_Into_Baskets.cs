public class Solution {
    public int TotalFruit(int[] fruits) {
        int maxFruits = 0; // Required output
        // Sliding Window Pattern (Dynamic Window Size)
        int left = 0, right = 0;
        int numOfCurrentFruits = 0;                 // Number of existing fruits in the baskets
        int[] baskets = new int[fruits.Length];     // 0 <= fruits[i] < fruits.length

        for(right = 0; right < fruits.Length; right++){
            if(baskets[fruits[right]] == 0){
                if(numOfCurrentFruits == 2){        // Shrink window from left
                    // Check max length
                    if(maxFruits < right - left){
                        maxFruits = right - left;
                    }
                    // Shrink window until the left fruit type is removed with its dupicates
                    while(baskets[fruits[left]] > 0 && numOfCurrentFruits == 2){
                        baskets[fruits[left]]--;
                        if(baskets[fruits[left]] == 0)
                            numOfCurrentFruits--;
                        left++;
                    }
                }
                // Add the new fruit to the window
                baskets[fruits[right]]++;
                numOfCurrentFruits++;
            }
            else{   // Increase quantity of existing fruit in the basket
                baskets[fruits[right]]++;
            }
        }
        return maxFruits > right - left ? maxFruits : right - left;
    }
}