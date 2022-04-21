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
}
