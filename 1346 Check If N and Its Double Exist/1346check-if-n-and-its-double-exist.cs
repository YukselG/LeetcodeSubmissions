public class Solution {
    public bool CheckIfExist(int[] arr) {
        /*
        if (arr.Length == 0 || arr.Length == 1)
        {
            return false;
        }
        */
        
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j && arr[i] == 2*arr[j])
                {
                    return true;
                }
            }
        }
        return false;
        
    }
}