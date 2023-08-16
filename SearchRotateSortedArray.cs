public class Solution {
    public int Search(int[] nums, int target) {
       int start = 0; int end = nums.Length-1;
        int result = -1;
        for(int i = 0; i< nums.Length; i++)
        {
           if(nums[start] == target)
           {
               result = start;
               break;
           }
           else if(nums[end] == target)
           {
               result = end;
                break;
           } 
           start ++;
           end--;
        }
        return result;
    } 
}