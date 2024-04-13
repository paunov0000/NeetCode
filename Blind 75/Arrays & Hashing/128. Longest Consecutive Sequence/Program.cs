using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public static void Main(string[] args)
    {
        var nums = new int[6] { 100, 4, 200, 1, 3, 2 };
        //var nums = new int[] { 1, 2, 0, 1 };
        //var nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        var longestConsecutive = LongestConsecutive(nums);
        Console.WriteLine(longestConsecutive);
    }

    public static int LongestConsecutive(int[] nums)
    {
        var hashset = new HashSet<int>(nums);
        int max = 0;
        int count;
        foreach (var num in hashset)
        {
            var isFirstOfSequence = hashset.Contains(num - 1) == false;

            if (isFirstOfSequence)
            {
                count = 1;
                while (hashset.Contains(num + count))
                {
                    count++;
                }

                max = Math.Max(max, count);
            }
        }

        return max;
    }
}