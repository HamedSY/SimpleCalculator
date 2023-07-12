using NSubstitute;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace SimpleCalculator.Tests;

public class MultiplyOperatorTest
{
    [Theory]
    [InlineData(12, 3, 4)]
    [InlineData(72, 9, 8)]
    [InlineData(9, 3, 3)]
    [InlineData(100000, 10, 10000)]
    public void MultiplyOperator_TypicalMult(int expectedResult, int multiplier, int multiplicand)
    {
        // Arrange
        var multiplyOperator = new MultiplyOperator();

        // Act
        var result = multiplyOperator.Calculate(multiplier, multiplicand);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void MultiplyOperator_MultiplyByOne_ExceptZero()
    {
        // Arrange
        var multiplier = 1;
        var multiplicand = Arg.Is<int>(x => x != 0);
        var multiplyOperator = new MultiplyOperator();

        // Act
        var result = multiplyOperator.Calculate(multiplier, multiplicand);

        // Assert
        Assert.Equal(multiplicand, result);
    }

    [Fact]
    public void MultiplyOperator_MultiplyByZero()
    {
        // Arrange
        var multiplier = 0;
        var multiplicand = Arg.Any<int>();
        var multiplyOperator = new MultiplyOperator();

        // Act
        var result = multiplyOperator.Calculate(multiplier, multiplicand);

        // Assert
        Assert.Equal(0, result);
    }
}