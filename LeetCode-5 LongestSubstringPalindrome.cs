public class Solution {
    public string LongestPalindrome(string input) 
{        
	int startIndex = 0, maxLength = 0;

	if (string.IsNullOrEmpty(input) || input.Length < 2)
	{
		return input;
	}

	for (int i = 0; i < input.Length - 1; i++)
	{
		// assume odd length, try to extend Palindrome as possible
		extendPalindrome(i, i);

		// assume even length.
		extendPalindrome(i, i + 1);
	}

	string result = input.Substring(startIndex, maxLength);
	return result;

	void extendPalindrome(int start, int end)
	{
		while (start >= 0 && end < input.Length && input[start] == input[end])
		{
			start--;
			end++;
		}

		if (maxLength < end - start - 1)
		{
			startIndex = start + 1;
			maxLength = end - start - 1;
		}
	}        
}
}