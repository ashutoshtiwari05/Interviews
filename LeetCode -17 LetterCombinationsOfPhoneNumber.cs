public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>();
        if(digits == null || digits.Length < 1)
            return result;
        
        string[] mapping = {
            "0","1","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"                        
        };
        
        FindCombinations(result, digits,mapping,"",0);
        return result;
    }
    
    public void FindCombinations(IList<string> result, string digits, string[] mapping, string currentVal, int index)
    {
        if(index == digits.Length)
        {
            result.Add(currentVal);
            return;
        }
        Console.WriteLine("{0},{1}",currentVal,index);
        var letters = mapping[digits[index] - '0'];
        
        for(int i =0;i<letters.Length;i++)
        {
            FindCombinations(result,digits,mapping, currentVal+letters[i],index+1);
        }        
    }
}