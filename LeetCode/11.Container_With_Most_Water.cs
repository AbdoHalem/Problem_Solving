public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0, right = height.Length - 1;
        while(right > left){
            int currentHeight = height[left] < height[right] ? height[left] : height[right];
            int area = currentHeight * (right - left);
            if(area > maxArea){
                maxArea = area;
            }
            if(height[left] < height[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return maxArea;
    }
}