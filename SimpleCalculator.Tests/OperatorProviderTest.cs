using NSubstitute;
using SimpleCalculator.Business.Enums;
using SimpleCalculator.Business.OperatorBusiness;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace SimpleCalculator.Tests;

public class OperatorProviderTest
{
    [Theory]
    [InlineData(typeof(SumOperator), OperatorEnum.Sum)]
    [InlineData(typeof(SubOperator), OperatorEnum.Sub)]
    [InlineData(typeof(MultiplyOperator), OperatorEnum.Multiply)]
    [InlineData(typeof(DivisionOperator), OperatorEnum.Division)]
    public void OperatorProvider_ReturnsTheSuitableObjectType(Type type, OperatorEnum operatorEnum)
    {
        // Arrange
        var operatorProvider = new OperatorProvider();
        
        // Act
        var result = operatorProvider.GetOperator(operatorEnum);

        // Assert
        Assert.Equal(type, result.GetType());
    }

    //TODO Write a test for OperatorProvider when throws exception
}