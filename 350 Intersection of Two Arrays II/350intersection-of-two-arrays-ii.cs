public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        
        Dictionary<int, int> dictNums1 = new Dictionary<int, int>();
        //Dictionary<int, int> dictNums2 = new Dictionary<int, int>();
        
        for (int i = 0; i < nums1.Length; i++)
        {
            if (dictNums1.ContainsKey(nums1[i]))
            {
                dictNums1[nums1[i]] = dictNums1[nums1[i]] + 1; 
            } else {
                dictNums1.Add(nums1[i], 1);
            }
        }
        
        for (int i = 0; i < nums2.Length; i++)
        {
            if (dictNums1.ContainsKey(nums2[i]))
            {
                if (dictNums1[nums2[i]] > 0)
                {
                    result.Add(nums2[i]);
                    dictNums1[nums2[i]] = dictNums1[nums2[i]] - 1; 
                }
            }
        }
        
        /*
        for (int i = 0; i < nums2.Length; i++)
        {
            if (dictNums2.ContainsKey(nums2[i]))
            {
                dictNums2[nums2[i]] = dictNums2[nums2[i]] + 1; 
            } else {
                dictNums2.Add(nums2[i], 1);
            }
        }
        
        //int lowestLength = nums1.Length < nums2.Length ? nums1.Length : nums2.Length;
        
        if (nums1.Length < nums2.Length)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                //Console.WriteLine("i: " + i);
                if (dictNums1.ContainsKey(nums1[i]) && dictNums2.ContainsKey(nums1[i]))
                {
                    int value1 = dictNums1[nums1[i]];
                    int value2 = dictNums2[nums1[i]];

                    int lowerOccurence = value1 < value2 ? value1 : value2;
                    //Console.WriteLine(lowerOccurence);
                
                    while (lowerOccurence > 0)
                    {
                        result.Add(nums1[i]);
                        lowerOccurence--;
                    }
                    dictNums1.Remove(nums1[i]);
                    dictNums2.Remove(nums1[i]);
                }
            }
        } else {
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictNums1.ContainsKey(nums2[i]) && dictNums2.ContainsKey(nums2[i]))
                {
                    int value1 = dictNums1[nums2[i]];
                    int value2 = dictNums2[nums2[i]];
                
                    int lowerOccurence = value1 < value2 ? value1 : value2;
                    //Console.WriteLine("loop2: " + lowerOccurence);
                    
                    while (lowerOccurence > 0)
                    {
                        result.Add(nums2[i]);
                        lowerOccurence--;
                    }
                    dictNums1.Remove(nums2[i]);
                    dictNums2.Remove(nums2[i]);
                }
            }
        }
        */
        
        
        
        return result.ToArray(); 
    }
}