using NSubstitute;
using SimpleCalculator.Business.Abstraction;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace SimpleCalculator.Tests;

public class DivisionOperatorTest
{
    [Theory]
    [InlineData(2, 10, 5)]
    [InlineData(3, 15, 5)]
    [InlineData(4, 16, 4)]
    [InlineData(10, 20, 2)]
    public void CalculateDivisionOperator_ShouldReturnTheCorrectResult_WhenTheDivisorIsNotZero(
        int expectedResult, int dividend, int divisor)
    {
        // Arrange
        var divisionOperator = new DivisionOperator();

        // Act
        var result = divisionOperator.Calculate(dividend, divisor);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    
    [Fact]
    public void CalculateDivisionOperator_ShouldReturnTheCorrectResult_WhenTheDivisorIsZero()
    {
        // Arrange
        var dividend = Arg.Any<int>();
        var divisor = 0;
        var divisionOperator = new DivisionOperator();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => divisionOperator.Calculate(dividend, divisor));
    }
}