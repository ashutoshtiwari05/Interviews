public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int len = s.Length;
        Dictionary<char, int> uniqueChar= new Dictionary<char, int>();
        Dictionary<string, int> subStringInfo= new Dictionary<string, int>();
        
        int i =0;
        int j =0;
        int max =0;
        
        while(j<len)
        {
            if(uniqueChar.ContainsKey(s[j]))
            {
                uniqueChar.Remove(s[i]);
                i++;                
            }
            else
            {
                uniqueChar.Add(s[j],j);
                max =  Math.Max(max, uniqueChar.Count());
                j++;
            }
        }
        return max;
    }
}