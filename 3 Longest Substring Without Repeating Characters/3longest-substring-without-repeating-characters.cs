public class Solution {
    public int LengthOfLongestSubstring(string s) {
    
        if (s.Length == 0)
        {
            return 0;
        }
        if (s.Length == 1)
        {
            return 1;
        }
        
        int result = 0;                       
        int highest = 0;
        HashSet<char> charSet = new HashSet<char>();

        
        for (int i = 0; i < s.Length; i++)
        {
            if (result > highest)
            {
                highest = result;
            }
            result = 0;
            charSet.Clear();
            for (int j = i; j < s.Length; j++)
            {
                if (charSet.Contains(s[j]))
                {
                    break;
                } else {
                    charSet.Add(s[j]);
                    result++;
                }
            } 
        }
        
        return highest;
    }
}