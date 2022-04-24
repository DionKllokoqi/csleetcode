namespace ThreeSumMultiplicity;

public class ThreeSumSolution
{
    private static int combinations = 0;

    public int ThreeSumMulti(int[] arr, int target)
    {
        int[] Li = GetSetOfPossibleComplements(arr[(1..^0)], target);
        int[] Lj = GetSetOfPossibleComplements(arr[(2..^0)], target);
        int[] Lk = GetSetOfPossibleComplements(arr[(3..^0)], target);

        throw new NotImplementedException();
    }

    private int[] GetSetOfPossibleComplements(int[] arr, int target)
    {
        throw new NotImplementedException();
    }

    public int ThreeSumMultiRec(int[] arr, int target)
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
        if (s.Equals(target) && partial.Count == 3)
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
            List<int> partial_rec = new List<int>(partial); // We need to copy the list, otherwise the
                                                            // the reference is passed and we add duplicate
                                                            // elements to the list
            partial_rec.Add(n);
            ThreeSumMultiRecursive(remaining, target, partial_rec);
        }
    }
}
