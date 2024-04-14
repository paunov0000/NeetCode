public class Solution
{
    public static void Main(string[] args)
    {
        var text1 = "A man, a plan, a canal: Panama";
        var text2 = "race a car";
        var text3 = " ";

        var output1 = IsPalindrome(text1);
        var output2 = IsPalindrome(text2);
        var output3 = IsPalindrome(text3);

        Console.WriteLine(output1);
        Console.WriteLine(output2);
        Console.WriteLine(output3);
    }
    public static bool IsPalindrome(string s)
    {
        var normalized = s.ToLower();
        var output = new List<char>();
        foreach (char c in normalized)
        {
            if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
            {
                output.Add(c);
            }
        }

        for (int i = 0; i < output.Count; i++)
        {
            var first = output[i];
            var last = output[output.Count - 1 - i];
            if (first != last)
            {
                return false;
            }
        }

        return true;
    }
}