public class Solution {
    public int FindMin(int[] nums) {
        int start = 0; int end = nums.Length-1;
        int result = nums[0];
        for(int i = 0; i < nums.Length/2; i++)
        {
            if(nums[start] > nums[start + 1])
            {
                result = nums[start+1];
                break;
            }
            else if(nums[end] < nums[end - 1])
            {
                result = nums[end];
                break;
            }
            start++;
            end--;
        }
        return result;
    }
}