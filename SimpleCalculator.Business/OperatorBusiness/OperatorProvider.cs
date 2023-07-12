using SimpleCalculator.Business.Abstraction;
using SimpleCalculator.Business.Enums;
using SimpleCalculator.Business.OperatorBusiness.Operators;

namespace SimpleCalculator.Business.OperatorBusiness
{
    public class OperatorProvider : IOperatorProvider
    {
        public IOperator GetOperator(OperatorEnum operatorType)
        {
            return operatorType switch
            {
                OperatorEnum.Sum => new SumOperator(),
                OperatorEnum.Sub => new SubOperator(),
                OperatorEnum.Multiply => new MultiplyOperator(),
                OperatorEnum.Division => new DivisionOperator(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}