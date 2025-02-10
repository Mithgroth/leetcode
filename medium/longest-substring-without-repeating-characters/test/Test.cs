using src;

namespace test;

public class Test
{
    public static IEnumerable<object[]> GetExamples()
    {
        yield return new object[]
        {
            "abcabcbb",
            3,
        };

        yield return new object[]
        {
            "bbbbb",
            1,
        };

        yield return new object[]
        {
            "pwwkew",
            3,
        };
    }

    [Theory]
    [MemberData(nameof(GetExamples))]
    public void Test1(string s, int expected)
    {
        var actual = Solution.LengthOfLongestSubstring(s);
        Assert.Equivalent(actual, expected);
    }
}