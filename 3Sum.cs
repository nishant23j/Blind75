public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        
        Array.Sort(nums);
        for(int i = 0; i< nums.Length; i++)
        {
            if(i>0 && nums[i] == nums[i-1])
            {
                continue;
            }
            int l = i + 1;
            int r = nums.Length-1;
            while(l<r)
            {   IList<int> resInt = new List<int>();
                int threeSum = nums[i] + nums[l] + nums[r];
                if(threeSum > 0){
                    r--;
                }
                else if(threeSum < 0){
                    l++;
                }
                else 
                {
                    resInt.Add(nums[i]);
                    resInt.Add(nums[l]);
                    resInt.Add(nums[r]);
                    res.Add(resInt);
                    l += 1;
                    while(nums[l] == nums[l-1] && l<r){
                        l += 1;
                    }
                }
            }

        }
        return res; 
    }
}