public class Solution {
    public int MinOperations(int[] nums, int x) {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        int sumOfArray = 0;
        
        foreach(var num in nums)
            sumOfArray+=num;
        
        int res = sumOfArray-x;
        
        myDict.Add(0,-1);
        int maxLen =-1;
        int prefixSum = 0;
        for(int i =0;i<nums.Length;i++)
        {
            prefixSum += nums[i];
            myDict.Add(prefixSum, i);
            
            if(myDict.ContainsKey(prefixSum-res))
            {
                maxLen = Math.Max(maxLen, i-myDict[prefixSum-res]);
            }            
        }
        return maxLen == -1 ? maxLen : nums.Length-maxLen;
    }
}