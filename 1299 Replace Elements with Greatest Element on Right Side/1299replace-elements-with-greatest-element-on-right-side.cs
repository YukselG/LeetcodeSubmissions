public class Solution {
    public int[] ReplaceElements(int[] arr) {
        /*
        if (arr.Length == 1)
        {
            arr[arr.Length-1] = -1;
            return arr;
        }
        
        if (arr.Length == 2)
        {
            arr[0] = arr[1];
            arr[1] = -1;
            
            return arr;
        }
        
        for (int i = 0; i < arr.Length-1; i++)
        {
            int biggestNumberIndex = arr.Length-1;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] > arr[biggestNumberIndex])
                {
                    arr[i] = arr[j];
                    biggestNumberIndex = j;
                } else {
                    arr[i] = arr[biggestNumberIndex];
                }
            }
        }
        //arr[arr.Length-2] = arr[arr.Length-1];
        arr[arr.Length-1] = -1;


        return arr;
        */
        
        int highestNumber = arr[arr.Length-1];
        for (int i = arr.Length-1-1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = highestNumber;
            if (temp > highestNumber)
            {
                highestNumber = temp;
            }
        }
        
        arr[arr.Length-1] = -1;
        
        return arr;
    }
}