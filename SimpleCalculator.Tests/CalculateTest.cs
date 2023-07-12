using SimpleCalculator.Business;
using SimpleCalculator.Business.Enums;

namespace SimpleCalculator.Tests;

public class CalculateTest
{
    [Theory]
    [InlineData(8, 3, 5, OperatorEnum.Sum)]
    [InlineData(-5, 6, 11, OperatorEnum.Sub)]
    [InlineData(-12, -2, 6, OperatorEnum.Multiply)]
    [InlineData(4, 20, 5, OperatorEnum.Division)]
    public void Calculate_ReturnsCorrectlyRelatedToItsEnum(int expectedResult, int operand1, int operand2,
        OperatorEnum operatorEnum)
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Calculate(operand1, operand2, operatorEnum);
        
        // Assert
        Assert.Equal(expectedResult, result);
    }
}