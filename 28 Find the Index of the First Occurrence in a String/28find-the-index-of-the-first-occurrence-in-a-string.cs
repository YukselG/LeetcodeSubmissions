public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        int haystackIterator = 0;
        int needleIterator = 0;
        int needleLength = needle.Length;
        
        int needleIndex = 0;
        
        for (int i = 0; i <= haystack.Length-needle.Length; i++)
        {
                for (needleIndex = 0; needleIndex < needle.Length; needleIndex++)
                {
                    if (needle[needleIndex] != haystack[i+needleIndex])
                    {
                        break;
                    } 
                }
            
            if (needleIndex == needle.Length)
            {
                return i;
            }
        }
        return -1;
    }
}
