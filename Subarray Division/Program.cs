using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        int n = s.Count;

        if (n < m)
        {
            return count;
        }

        int windowSum = s.Take(m).Sum();

        if (windowSum == d)
        {
            count++;
        }

        for (int i = 1; i <= n - m; i++)
        {
            windowSum = windowSum - s[i - 1] + s[i + m - 1];

            if (windowSum == d)
            {
                count++;
            }
        }

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = 5;
        List<int> s = new List<int> { 1, 2, 1, 3, 2 }; 
        int d = 3; 
        int m = 2; 
        // Alternatively, you can change the hardcoded values to test different cases
        // int n = 6;
        // List<int> s = new List<int> { 1, 1, 1, 1, 1, 1 };
        // int d = 3;
        // int m = 2;

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);
    }
}
