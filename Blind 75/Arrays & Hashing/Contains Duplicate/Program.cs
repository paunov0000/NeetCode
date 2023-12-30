// See https://aka.ms/new-console-template for more information

public class Solution
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(',').Select(i => int.Parse(i)).ToArray();
        Console.WriteLine(ContainsDuplicate(input));
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (dictionary.ContainsKey(nums[i]))
            {
                return true;
            }

            dictionary.Add(nums[i], 1);
        }

        return false;
    }
}



