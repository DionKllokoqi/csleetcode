using ThreeSumMultiplicity;
using Xunit;

namespace ThreeSumMultiplicityTests;

public class SolutionTests
{
    [Fact]
    public void ThreeSumMulti_OnGenericInput_ReturnsNrOfTuples()
    {
        // Arrange
        var threeTierMulti = new Solution();
        int[] arr = new int[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5};
        int target = 8;

        // Act
        var actual = threeTierMulti.ThreeSumMulti(arr, target);
        var expected = 20;

        // Assert
        Assert.Equal(actual, expected);
    }
}