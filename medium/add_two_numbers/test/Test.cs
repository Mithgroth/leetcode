using src;

namespace test;

public class Test
{
    public static IEnumerable<object[]> GetExamples()
    {
        yield return new object[] 
        { 
            new ListNode(2, new(4, new(3))),
            new ListNode(5, new(6, new(4))),
            new ListNode(7, new(0, new(8))),
        };

        yield return new object[]
        {
            new ListNode(0),
            new ListNode(0),
            new ListNode(0),
        };

        yield return new object[]
        {
            new ListNode(9, new(9, new(9, new(9, new(9, new(9, new(9))))))),
            new ListNode(9, new(9, new(9, new(9)))),
            new ListNode(8, new(9, new(9, new(9, new(0, new(0, new(0, new(1)))))))),
        };
    }

    [Theory]
    [MemberData(nameof(GetExamples))]
    public void Test1(ListNode l1, ListNode l2, ListNode expected)
    {
        var actual = Solution.AddTwoNumbers(l1, l2);
        Assert.Equivalent(expected, actual);
    }
}