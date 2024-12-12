public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seenNumbers = new HashSet<int>();
        int newNumber = n;
        
        while (n != 1)
        {
            // we check if we already have seen the number, if so we have a cycle
            if (seenNumbers.Contains(n))
            {
                return false;
            }
            
            // add the number if no cycle
            seenNumbers.Add(n);
            n = SumOfDigitsSquared(n); 
        }
        
        // function to get the sum of the digits squared
        int SumOfDigitsSquared (int number)
        {
            int sumOfSquares = 0;
            // while loop to iterate through each digit
            while (number > 0)
            {
                int digit = number % 10;
                
                int digitSquared = digit*digit;
                
                sumOfSquares = sumOfSquares + digitSquared;
                
                number = number / 10;
            }
            
            // returning the new number that is sum of the digits squared
            return sumOfSquares;
        }
        
        return true;
        
    }
}