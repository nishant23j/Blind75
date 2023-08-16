public class Solution {
    public int MaxProduct(int[] nums) {
        int max = 1;
        int min = 1;
        int prod = 1;
        int maxprod = nums[0];
        
        for(int i = 1; i< nums.Length; i++)
        {
            if(maxprod< nums[i])
            {
                maxprod = nums[i];
            }
        }
        for(int i = 0; i< nums.Length; i++)
        {
            
            if(nums[i] == 0)
            {
                max = 1;
                min = 1;
                continue;
            }
            else 
            {
                int maxtmp = nums[i] * max;
                
                int mintmp = nums[i] * min;
                
                max = Math.Max(maxtmp, mintmp);
                max = Math.Max(max, nums[i]); 
                min = Math.Min(maxtmp, mintmp);
                min = Math.Min(min, nums[i]);            
            }
            maxprod = Math.Max(max, maxprod); 
        }
        
        return maxprod;
    }
}
