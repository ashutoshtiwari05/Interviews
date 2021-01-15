public class Solution {
    public int MinOperations(int[] nums, int x) {
        int sumOfArray = 0;
        
        foreach(var num in nums)
            sumOfArray+=num;
        
        int res = sumOfArray-x;
        
        if(res<0) return -1;
        
        int maxLen =-1;
        int prefixSum = 0;
        int left = 0;
        
        for(int i =0;i<nums.Length;i++)
        {
            prefixSum += nums[i];
            while(prefixSum>res)
            {
                prefixSum -= nums[left];
                left++;
            }
            if(prefixSum == res)
                maxLen = Math.Max(maxLen, i-left+1);
        }
        return maxLen == -1 ? maxLen : nums.Length-maxLen;
    }
}