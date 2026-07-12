public class Solution {
    public int Trap(int[] height)
    {
        int units = 0;
        int left = 0, right = height.Length - 1;
        int leftMaxHeight = 0, rightMaxHeight = 0;

        while (right >= left)
        {
            if (height[left] > leftMaxHeight)
            {
                leftMaxHeight = height[left];
            }
            if (height[right] > rightMaxHeight)
            {
                rightMaxHeight = height[right];
            }
            if (leftMaxHeight > rightMaxHeight)
            {
                units += rightMaxHeight - height[right];
                right--;
            }
            else
            {
                units += leftMaxHeight - height[left];
                left++;
            }
        }
        return units;
    }
}