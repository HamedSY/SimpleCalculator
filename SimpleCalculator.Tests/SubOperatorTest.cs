using NSubstitute;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace SimpleCalculator.Tests;

public class SubOperatorTest
{
    [Theory]
    [InlineData(7, 10, 3)]
    [InlineData(50, 100, 50)]
    [InlineData(-1, 699, 700)]
    public void SubOperator_TypicalSub(int expectedResult, int minuend, int subtrahend)
    {
        // Arrange
        var subOperator = new SubOperator();
        
        // Act
        var result = subOperator.Calculate(minuend, subtrahend);
        
        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void SubOperator_ANumberSubtractsFromItsNegative()
    {
        // Arrange
        var minuend = Arg.Any<int>();
        var subtrahend = -minuend;
        var subOperator = new SubOperator();
        
        // Act
        var result = subOperator.Calculate(minuend, subtrahend);
        
        // Assert
        Assert.Equal(0, result);
    }
}