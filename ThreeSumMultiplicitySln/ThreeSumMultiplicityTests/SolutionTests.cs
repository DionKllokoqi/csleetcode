using ThreeSumMultiplicity;
using Xunit;

namespace ThreeSumMultiplicityTests;

public class SolutionTests
{
    [Theory]
    [InlineData(new int[]{2, 1, 3}, 6, 1)]
    public void ThreeSumMulti_OnSimpleInput_ReturnsNrOfTuples(int[] arr, int target, int expected)
    {
        // Arrange
        var threeTierMulti = new Solution();

        // Act
        var actual = threeTierMulti.ThreeSumMulti(arr, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] {1, 1, 2, 2, 2, 2}, 5, 12)]
    [InlineData(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5}, 8, 20)]
    public void ThreeSumMulti_OnGenericInput_ReturnsNrOfTuples(int[] arr, int target, int expected)
    {
        // Arrange
        var threeTierMulti = new Solution();

        // Act
        var actual = threeTierMulti.ThreeSumMulti(arr, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}