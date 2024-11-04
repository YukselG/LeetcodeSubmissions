public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // thinking about a different approach, not done
        /*if (nums1[nums1.Length-1] <= nums2[nums2.Length-1])
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums1[nums.Length+i] = nums2[i];
            }
        }
        int nums1length = nums.Length;
        int i = 0;
        else if (nums1[nums1length] > nums2[i])
        {
            
        }
        */
        
        // addind nums2 values to nums1 array
        for (int i = 0; i < nums2.Length; i++)
        {
            nums1[m+i] = nums2[i];
            System.Console.WriteLine(nums1[m+i]);
        }
        
        // bubble sort nums1 array
        for (int i = 0; i < nums1.Length-1; i++)
        {
            for (int j = 0; j < nums1.Length-1; j++)
            {
                if (nums1[j] > nums1[j+1])
                {
                    int temp = nums1[j+1];
                    nums1[j+1] = nums1[j];  
                    nums1[j] = temp;
                }
            }

        }
    }
}