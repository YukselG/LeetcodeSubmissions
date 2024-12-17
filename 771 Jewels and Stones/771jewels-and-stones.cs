public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int result = 0;
        
        /*
        // Using a HashMap
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < stones.Length; i++)
        {
            if (dict.ContainsKey(stones[i]))
            {
                dict[stones[i]] = dict[stones[i]] + 1;
            } else {
                dict.Add(stones[i], 1);
            }
        }
        
        for (int i = 0; i < jewels.Length; i++)
        {
            if (dict.ContainsKey(jewels[i]))
            {
                result = result + dict[jewels[i]];
            }
        }
        */
        
        // Using nested loops, which in this case is fine, since the constraints limits the input to be of size 50 only
        for (int i = 0; i < stones.Length; i++)
        {
            for (int j = 0; j < jewels.Length; j++)
            {
                if (stones[i] == jewels[j])
                {
                    result = result + 1;
                }
            }
        }
        
        return result;
    }
}