public class Solution {
    public int FirstUniqChar(string s) {
        if (s.Length == 1)
        {
            return 0;
        }
        
        Dictionary<char, int> uniqDict = new Dictionary<char,int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (uniqDict.ContainsKey(s[i]))
            {
                uniqDict[s[i]] = uniqDict[s[i]] + 1;
            } else {
                uniqDict.Add(s[i], 1);
            }
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            int occurrence = uniqDict[s[i]];
            if (occurrence == 1)
            {
                return i;
            }
        }
        
        return -1;
    }
}