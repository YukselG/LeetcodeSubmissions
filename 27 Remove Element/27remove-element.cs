public class Solution {
    public int RemoveElement(int[] nums, int val) {
        /*
        // Not working fully
        int valCount = 0;
        for (int i = 0; i < nums.Length-valCount; i++)
        {
                System.Console.WriteLine("i: " + i);                
                System.Console.WriteLine("before if nums[i]: " + nums[i]);
                if (nums[i] == val)
            {
                System.Console.WriteLine("nums[i]: " + nums[i]);
                System.Console.WriteLine("Valcount before: " + valCount);
                valCount = valCount+1;
                System.Console.WriteLine("Valcount after: " + valCount);
                for (int j = i; j < nums.Length-1; j++)
                {
                    nums[j] = nums[j+1];
                }
            }

            
        }
        return (nums.Length-valCount);
        */
        
        // Working solution, but O(n^2)
        /*
        int valCount = 0;
        if (nums.Length > 0 && nums[nums.Length-1] == val)
        {
            valCount++;
        }
        for (int i = nums.Length-1-1; i >= 0; i--)
        {
            if (nums[i] == val)
            {
                valCount = valCount+1;
                for (int j = i; j < nums.Length-1; j++)
                {
                    nums[j] = nums[j+1];
                }
            }
            System.Console.WriteLine("after loop - i: " + i);
        }
        
        return (nums.Length-valCount);
        */
        
        
        // Better solution, O(n)
        int elementsToKeepCounter = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[elementsToKeepCounter] = nums[i];
                elementsToKeepCounter++;
            }
        }
        
        return (elementsToKeepCounter);
        
        
    }
}