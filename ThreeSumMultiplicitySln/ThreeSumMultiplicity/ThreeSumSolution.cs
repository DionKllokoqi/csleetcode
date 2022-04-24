namespace ThreeSumMultiplicity;

public class ThreeSumSolution
{
    private static int combinations = 0;

    public int ThreeSumMultiDict(int[] arr, int target)
    {
        int n = arr.Length, mod = 1_000_000_007, ans = 0;
        Dictionary<int, int>? m = new Dictionary<int, int>();
        
        for(int i=0; i<n; i++) 
        {
            if (m.ContainsKey(target - arr[i]))
            {
                ans = (ans + m[target - arr[i]]) % mod;
            }
            
            for(int j=0; j<i; j++) 
            {
                int count;
                int key = arr[i] + arr[j];

                if (m.TryGetValue(key, out count))
                    count++;
                else
                    m.Add(key, 1);
            }
        }
        return ans;

    }

    public int ThreeSumMultiTwoSum(int[] A, int target)
    {
        int MOD = 1_000_000_007;
        long ans = 0;
        Array.Sort(A);

        for (int i = 0; i < A.Length; ++i) {
            // We'll try to find the number of i < j < k
            // with A[j] + A[k] == T, where T = target - A[i].

            // The below is a "two sum with multiplicity".
            int T = target - A[i];
            int j = i + 1, k = A.Length - 1;

            while (j < k)
            {
                // These steps proceed as in a typical two-sum.
                if (A[j] + A[k] < T)
                    j++;
                else if (A[j] + A[k] > T)
                    k--;
                else if (A[j] != A[k])
                {
                    // We have A[j] + A[k] == T.
                    // Let's count "left": the number of A[j] == A[j+1] == A[j+2] == ...
                    // And similarly for "right".
                    int left = 1, right = 1;
                    while (j + 1 < k && A[j] == A[j + 1]) {
                        left++;
                        j++;
                    }
                    while (k - 1 > j && A[k] == A[k - 1]) {
                        right++;
                        k--;
                    }

                    ans += left * right;
                    ans %= MOD;
                    j++;
                    k--;
                }
                else
                {
                    // M = k - j + 1
                    // We contributed M * (M-1) / 2 pairs.
                    ans += (k - j + 1) * (k - j) / 2;
                    ans %= MOD;
                    break;
                }
            }
        }

        return (int) ans;
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
