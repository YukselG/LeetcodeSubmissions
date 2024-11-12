public class Solution {
     public bool ValidMountainArray(int[] arr) {
         
         if (arr.Length < 3)
         {
             return false;
         }
         
         int highestPointIndex = (arr.Length-1);
         
         
         for (int i = 0; i < arr.Length; i++)
         {
             if (arr[i] > arr[highestPointIndex])
             {
                 highestPointIndex = i;
             }
         }
         
                      
         if (highestPointIndex == (arr.Length-1) || highestPointIndex == 0)
         {
             return false;
         }
         
         for (int i = 0; i < highestPointIndex; i++)
         {
             if (arr[i] >= arr[i+1])
             {
                 return false;
             }
         }
         
         for (int i = highestPointIndex; i < arr.Length-1; i++)
         {
             if (arr[i] <= arr[i+1])
             {
                 return false;
             }
         }

         return true;
    }
}
        
