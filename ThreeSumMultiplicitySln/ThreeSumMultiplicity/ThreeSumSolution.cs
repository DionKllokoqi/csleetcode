namespace ThreeSumMultiplicity;

public class ThreeSumSolution
{
    private static int combinations = 0;

    public int ThreeSumMulti(int[] arr, int target)
    {
        int[] Li = GetSetOfPossibleComplements(arr[(0..^2)], target);

        List<int[]> Si = new List<int[]>();
        for (int i = 0; i < Li.Length; i++)
        {
            var possibleTarget = Li[i];
            Si.AddRange(GetCombinationsToTarget(arr[(i + 1)..^1], arr[(i + 2)..^0], possibleTarget));
        }

        return Si.Count;
    }

    private List<int[]> GetCombinationsToTarget(int[] arr1, int[] arr2, int possibleTarget)
    {
        List<int[]> S = new List<int[]>();

        for (int x = 0; x < arr1.Length; x++)
        {
            for (int y = x; y < arr2.Length; y++)
            {
                if ((arr1[x] + arr2[y]) == possibleTarget)
                {
                    S.Add(new int[] {arr1[x], arr2[y]});
                }
            }
        }

        return S;
    }

    private int[] GetSetOfPossibleComplements(int[] arr, int target)
    {
        int[] L = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            L[i] = target - arr[i];
        }

        return L;
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
