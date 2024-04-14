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
        var l = 0;
        var r = s.Length - 1;
        while (l < r)
        {
            while (IsAlphanumeric(s[l]) == false && l < r)
            {
                l++;
            }
            while (IsAlphanumeric(s[r]) == false && l < r)
            {
                r--;
            }

            if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
            {
                return false;
            }

            l++;
            r--;

        }

        return true;
    }

    public static bool IsAlphanumeric(char s)
    {
        return (s >= '0' && s <= '9') || (s >= 'a' && s <= 'z') || (s >= 'A' && s <= 'Z');
    }
}