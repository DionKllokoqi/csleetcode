namespace ThreeSumMultiplicity;

public class Solution
{
    private static int combinations = 0;

    public int ThreeSumMulti(int[] arr, int target)
    {
        ThreeSumMultiRecursive(arr, target, new List<int>());
        var result = combinations;
        combinations = 0;           // Reset static value for next method call
        return result;
    }

    private void ThreeSumMultiRecursive(int[] arr, int target, List<int> partial)
    {
        // Determine current sum of combinations
        var s = partial.Sum();

        // Current combination reached target
        if (s.Equals(target))
        {
            combinations += 1;
            return;
        }

        // No need to continue, target surpassed
        if (s > target) return;

        for (int i = 0; i < arr.Length; i++)
        {
            var n = arr[i];
            var remaining = arr[(i + 1)..^0];
            partial.Add(n);
            ThreeSumMultiRecursive(remaining, target, partial);
        }
    }
}
