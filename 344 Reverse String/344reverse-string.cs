public class Solution {
    // recursive approach
    public void ReverseString(char[] s) {
        int startIndex = 0;
        int lastIndex = s.Length - 1;
        helper(s, startIndex, lastIndex);
    }
    
    public void helper (char[] s, int startIndex, int lastIndex)
    {
        if (s == null || lastIndex <= startIndex)
        {
            return;
        }
        
        char temp = s[lastIndex];
        s[lastIndex] = s[startIndex];
        s[startIndex] = temp;
        helper(s, startIndex+1, lastIndex-1);
    }
}