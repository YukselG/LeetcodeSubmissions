public class Solution {
    public bool IsPalindrome(int x) {
        bool result = true;
        var inputToString = x.ToString();
        var firstElement = 0;
        var lastElement = inputToString.Length - 1;

        for (int i = 0; i < inputToString.Length; i++)
        {
            if (inputToString[firstElement] != inputToString[lastElement])
            {
                result = false;
                return result;
            }
            firstElement++;
            lastElement--;
        }

        return result;
    }
}