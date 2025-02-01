public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>(numRows);

        for (int i = 0; i < numRows; i++)
        {
            result.Add(new List<int>(i+1));
            
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    result[i].Add(1);
                } else {
                    int val = result[i-1][j-1] + result[i-1][j];
                    result[i].Add(val);
                }
            }
        }

        return result;
    }
}