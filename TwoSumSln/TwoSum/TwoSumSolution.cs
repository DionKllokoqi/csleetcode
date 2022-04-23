namespace TwoSum;

public class TwoSumSolution
{
    /// <summary>
    /// Method solves the problem in O(n^2).
    /// </summary>
    /// <param name="arr">Input array.</param>
    /// <param name="target">Target value the sum of two arr elements should add up to.</param>
    /// <returns>Array with two elements representing the indices of the solution, or empty array.</returns>
    public int[] TwoSum(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if ((arr[i] + arr[j]) == target)
                {
                    return new int[] {i, j};
                }
            }
        }

        return new int[0];
    }

    /// <summary>
    /// Method solves the problem in O(nlogn), which is the complexity of the sort.
    /// The comparison algorithm per se takes only O(n), since it max it has to make n comparisons.
    /// </summary>
    /// <param name="arr">Input array.</param>
    /// <param name="target">Target value the sum of two arr elements should add up to.</param>
    /// <returns>Array with two elements representing the indices of the solution, or empty array.</returns>
    public int[] TwoSumNlogN(int[] arr, int target)
    {
        var sortedArr = new int[arr.Length];
        arr.CopyTo(sortedArr, 0);
        Array.Sort(sortedArr);

        int i = 0;
        int j = arr.Length - 1;

        while (true)
        {
            if (i != j)
            {
                if ((sortedArr[i] + sortedArr[j]) == target)
                {
                    if (sortedArr[i] != sortedArr[j])
                    {
                        i = Array.IndexOf(arr, sortedArr[i]);
                        j = Array.IndexOf(arr, sortedArr[j]);
                    }
                    else
                    {
                        i = Array.IndexOf(arr, sortedArr[i]);
                        j = Array.IndexOf(arr, sortedArr[j], i+1);
                    }
                    return new int[] {i, j};
                }
                else if ((sortedArr[i] + sortedArr[j]) > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            else
            {
                return new int[0];
            }
        }
    }

    /// <summary>
    /// Method solves the problem in O(n). arr values are added as keys to Dictionary / Hash Table,
    /// whereas their index is the value. We are simultaneously adding elements to the dictionary,
    /// while checking if the difference target - arr[i] already exists as a key in the dictionary.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] ToSumNHash(int[] arr, int target)
    {
        Dictionary<int, int> ht = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            var complement = target - arr[i];
            if (ht.ContainsKey(complement))
            {
                return new int[] { ht[complement], i };
            }
            ht[arr[i]] = i;
        }

        return new int[0];
    }
}
