public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        /*
        HashSet<int> set1 = new HashSet<int>(nums1);

        set1.IntersectWith(nums2);
        
        int[] result = new int[set1.Count];
        
        set1.CopyTo(result);
        return result;
        */
        
        // Without using too many built-in implementations
        List<int> result = new List<int>();
        
        HashSet<int> setNums1 = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            setNums1.Add(nums1[i]);
        }
        
        for (int i = 0; i < nums2.Length; i++)
        {
            if (setNums1.Contains(nums2[i]))
            {
                setNums1.Remove(nums2[i]);
                result.Add(nums2[i]);
            }
        }
        
        return result.ToArray<int>();
    }
}