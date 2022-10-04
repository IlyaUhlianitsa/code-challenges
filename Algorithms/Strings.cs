using System.Text;

namespace Algorithms;

public static class Strings
{
    // https://leetcode.com/problems/isomorphic-strings/?envType=study-plan&id=level-1
    public static bool IsIsomorphic(string s, string t)
    {
        var dict1 = new Dictionary<char, char>();
        var dict2 = new Dictionary<char, char>();
        for (var i = 0; i < t.Length; i++)
        {
            dict1.TryAdd(s[i], t[i]);
            dict2.TryAdd(t[i], s[i]);

            if (dict1[s[i]] != t[i] || dict2[t[i]] != s[i])
                return false;
        }

        return true;
    }

    // https://leetcode.com/problems/is-subsequence/?envType=study-plan&id=level-1
    public static bool IsSubsequence(string s, string t)
    {
        var index = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var found = false;
            while (index < t.Length)
            {
                if (t[index] == s[i])
                {
                    found = true;
                    index++;
                    break;
                }

                index++;
            }

            if (!found)
                return false;
        }

        return true;
    }
    
    // https://leetcode.com/problems/reverse-only-letters/
    public static string ReverseOnlyLetters(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
            if (char.IsLetter(c))
                stack.Push(c);

        var sb = new StringBuilder();
        foreach (var c in s) sb.Append(char.IsLetter(c) ? stack.Pop() : c);

        return sb.ToString();
    }
}