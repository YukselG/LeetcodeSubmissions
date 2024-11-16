public class Solution {
    public int HeightChecker(int[] heights) {
        int[] sortedHeights = new int[heights.Length];
        for (int i = 0; i < heights.Length; i++)
        {
            sortedHeights[i] = heights[i];
        }

       /* 
        for (int i = 0; i < sortedHeights.Length-1; i++)
        {
            for (int j = 0; j < sortedHeights.Length-1-i; j++)
            {
                if (sortedHeights[j] >= sortedHeights[j+1])
                {
                    int temp = sortedHeights[j+1];
                    sortedHeights[j+1] = sortedHeights[j];
                    sortedHeights[j] = temp;
                }
            }
        }
        */
        
        Array.Sort(sortedHeights);
        
        int numberOfHeightsNotMatching = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            System.Console.WriteLine(sortedHeights[i]);
            if (heights[i] != sortedHeights[i])
            {
                numberOfHeightsNotMatching++;
            }
        }
        
        return numberOfHeightsNotMatching;
    }
}