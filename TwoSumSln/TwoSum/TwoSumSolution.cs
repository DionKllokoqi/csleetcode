namespace TwoSum;

public class TwoSumSolution
{
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

    public int[] TwoSumEfficient(int[] arr, int target)
    {
        var sortedArr = new int[arr.Length];
        arr.CopyTo(sortedArr, 0);
        Array.Sort(sortedArr);

        int i = 0;
        int j = arr.Length - 1;

        while (true)
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
            else if ((sortedArr[i] + sortedArr[j]) < target)
            {
                i++;
            }
            else
            {
                return new int[0];
            }
        }
    }
}
