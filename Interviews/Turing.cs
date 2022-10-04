using System.Text;

namespace Interviews;

public class Turing
{
    // Find maximum not repeatable digit in each array and return max between results or -1
    public static int FindMaxUniqueValue(int[][] cards)
    {
        var result = -1;

        foreach (var arr in cards)
        {
            var res = arr.GroupBy(x => x).Where(x => x.Count() == 1).ToList();
            if (!res.Any())
                continue;

            var max = res.Max(x => x.Key);
            if (result <= max) result = max;
        }

        return result;
    }

    // https://leetcode.com/problems/reverse-only-letters/
    public static string ReverseOnlyLetters(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (char.IsLetter(c))
                stack.Push(c);
        }

        var sb = new StringBuilder();
        foreach (var c in s) 
            sb.Append(char.IsLetter(c) ? stack.Pop() : c);

        return sb.ToString();
    }
}