using NSubstitute;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace SimpleCalculator.Tests;

public class SumOperatorTest
{
    [Theory]
    [InlineData(7, 3, 4)]
    [InlineData(9, 1, 8)]
    [InlineData(781, 699, 82)]
    public void SumOperator_TypicalSum(int expectedResult, int addend1, int addend2)
    {
        // Arrange
        var sumOperator = new SumOperator();
        
        // Act
        var result = sumOperator.Calculate(addend1, addend2);
        
        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void SumOperator_SumOfZeroAndAddend()
    {
        // Arrange
        const int zero = 0;
        var addend = Arg.Any<int>();
        var sumOperator = new SumOperator();
        
        // Act
        var result = sumOperator.Calculate(zero, addend);
        
        // Assert
        Assert.Equal(addend, result);
    }
}