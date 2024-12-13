public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string sortedElement = sortElement(strs[i]);
            
            if (dict.ContainsKey(sortedElement))
            {
                dict[sortedElement].Add(strs[i]);
            } else {
                dict.Add(sortedElement, new List<string>());
                dict[sortedElement].Add(strs[i]);
            }
        }
        
        string sortElement (string element)
        {
            char[] elementToCharArray = element.ToCharArray();
            
            Array.Sort(elementToCharArray);
            
            return new string(elementToCharArray);
        }
        
        return dict.Values.ToList();
    }
}