using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public static void Main(string[] args)
    {
        //var nums = new int[6] { 100, 4, 200, 1, 3, 2 };
        var nums = new int[] { 1, 2, 0, 1 };
        //var nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        var longestConsecutive = LongestConsecutive(nums);
        Console.WriteLine(longestConsecutive);
    }

    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0 || nums.Length == 1)
        {
            return nums.Length;
        }

        var hashset = new HashSet<int>();
        int count;
        var ans = 1;

        foreach (var n in nums)
        {
            hashset.Add(n);
        }

        foreach (var n in hashset)
        {
            if (hashset.Contains(n - 1))
            {
                continue;
            }

            count = 1;

            var nextVal = n + 1;
            if (hashset.Contains(nextVal))
            {
                while (hashset.Contains(nextVal))
                {
                    count++;
                    nextVal++;
                }
                ans = Math.Max(ans, count);
            }
        }

        return ans;
    }
}