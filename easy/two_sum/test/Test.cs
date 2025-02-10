namespace test;

public class Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 1, 0 })]
    public void Test1(int[] nums, int target, int[] expected)
    {
        var actual = src.Solution.TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}
