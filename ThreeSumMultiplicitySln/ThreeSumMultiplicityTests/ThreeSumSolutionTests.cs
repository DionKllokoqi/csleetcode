using ThreeSumMultiplicity;
using Xunit;

namespace ThreeSumMultiplicityTests;

public class ThreeSumSolutionTests
{
    [Theory]
    [InlineData(new int[] {1, 1, 2, 2, 2, 2}, 5, 12)]
    [InlineData(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5}, 8, 20)]
    [InlineData(new int[]{2, 1, 3}, 6, 1)]
    public void ThreeSumMultiTwoSum_ReturnsNrOfTuples(int[] arr, int target, int expected)
    {
        // Arrange
        int MOD = 1_000_000_007;
        var threeTierMulti = new ThreeSumSolution();

        // Act
        var actual = threeTierMulti.ThreeSumMultiTwoSum(arr, target);

        // Assert
        Assert.Equal(expected % MOD, actual);
    }

    [Theory]
    [InlineData(new int[] {1, 1, 2, 2, 2, 2}, 5, 12)]
    [InlineData(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5}, 8, 20)]
    [InlineData(new int[]{2, 1, 3}, 6, 1)]
    public void ThreeSumMultiRecursive_ReturnsNrOfTuples(int[] arr, int target, int expected)
    {
        // Arrange
        var threeTierMulti = new ThreeSumSolution();

        // Act
        var actual = threeTierMulti.ThreeSumMultiRec(arr, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}