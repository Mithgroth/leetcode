namespace src;

public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        // Constraint: 0 <= s.length <= 5 * 10^4
        // Which means, we should never try to load the entire string into memory

        var max = 0;
        var span = s.AsSpan();
        var start = 0;

        while (start < span.Length)
        {
            var tempMax = 0;
            char[] current = [];
            var subSpan = span[start..];

            for (var i = 0; i < subSpan.Length; i++)
            {
                if (Array.IndexOf(current, subSpan[i]) != -1)
                {
                    break;
                }

                tempMax++;
                current = [.. current, subSpan[i]];
            }

            max = Math.Max(max, tempMax);
            start++;
        }

        return max;
    }
}
