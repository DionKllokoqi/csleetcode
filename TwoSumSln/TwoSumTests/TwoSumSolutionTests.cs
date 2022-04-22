using Xunit;
using TwoSum;

namespace TwoSumTests;

public class TwoSumSolutionTests
{
    [Theory]
    [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
    [InlineData(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
    [InlineData(new int[] {3, 3}, 6, new int[] {0, 1})]
    public void TwoSum_ShouldReturnTupleOfIndicesThatAddUpToTarget(int[] arr, int target, int[] expected)
    {
        // Arrange
    	var twoSumSolution = new TwoSumSolution();

        // Act
        var actual = twoSumSolution.TwoSum(arr, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    
    [Theory]
    [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
    [InlineData(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
    [InlineData(new int[] {3, 3}, 6, new int[] {0, 1})]
    public void TestTwoSumEfficient_ShouldReturnTupleOfIndicesThatAddUpToTarget(int[] arr, int target, int[] expected)
    {
        // Arrange
    	var twoSumSolution = new TwoSumSolution();

        // Act
        var actual = twoSumSolution.TwoSumEfficient(arr, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}