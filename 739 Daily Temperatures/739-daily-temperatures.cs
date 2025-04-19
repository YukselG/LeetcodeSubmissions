public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int[] answer = new int[temperatures.Length];
        
        // using a monotonically decreasing stack that stores indices of the temperatures array.
        // using this stack to calculate the difference between the indices (which gives us the days);
        Stack monDecStack = new Stack();
        
        // starting from the end of the temperatures array
        for (int i = temperatures.Length-1; i >= 0; i--)
        {
            // Popping indices with temperatures less than or equal to current
            while (monDecStack.Count != 0 && temperatures[(int)monDecStack.Peek()] <= temperatures[i])
            {
                monDecStack.Pop();
            }
            
            // if stack is empty, there is no value bigger than current element 
            if (monDecStack.Count == 0)
            {
                answer[i] = 0;
            } else if (temperatures[(int)monDecStack.Peek()] > temperatures[i])
            {
                answer[i] = (int)monDecStack.Peek() - i;
            }
            monDecStack.Push(i);
        }
        
        return answer;
        
        /*
        // brute force - gives time limit exceeded
        int[] answer = new int[temperatures.Length];
        
        for(int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine("i = " + i);
            int counter = 1;
            for (int j = i+1; j < temperatures.Length; j++)
            {
                Console.WriteLine("j = " + j );
                if (temperatures[j] > temperatures[i])
                {
                    answer[i] = counter;
                    Console.WriteLine("answer[i] = " + answer[i]);
                    break;
                }
               counter++;
            }
        }
        return answer;
        */
    }
}