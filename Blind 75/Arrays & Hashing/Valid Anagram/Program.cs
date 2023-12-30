public class Solution
{

    public static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("rat", "car"));
    }


    public static bool IsAnagram(string s, string t)
    {
        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        if (s.Length != t.Length)
        {
            return false;
        }


        for (int i = 0; i < s.Length; i++)
        {
            if (sDict.ContainsKey(s[i]))
            {
                sDict[s[i]]++;
            }
            else
            {
                sDict.Add(s[i], 1);
            }
            if (tDict.ContainsKey(t[i]))
            {
                tDict[t[i]]++;
            }
            else
            {
                tDict.Add(t[i], 1);
            }
        }

        foreach (var item in sDict)
        {
            if (!tDict.ContainsKey(item.Key) || tDict[item.Key] != item.Value)
            {
                return false;
            }
        }

        return true;
    }
}