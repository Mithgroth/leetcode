namespace src;

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] result = [];
        for (var i = 0; i < nums.Length; i++)
        {
            var required = target - nums[i];
            var index = Array.IndexOf(nums, required);
            if (index > -1 && i != index)
            {
                return [i, index];
            }
        }

        return result;
    }
}
