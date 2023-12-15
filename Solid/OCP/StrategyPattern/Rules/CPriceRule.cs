using OCP.StrategyPattern.Base;

namespace OCP.StrategyPattern.Rules;

public class CPriceRule : IPriceRule
{
    public decimal CalculatePrice(OrderItem item)
    {
        return item.Quantity * 8;
    }

    public bool IsMatch(OrderItem item)
    {
        return item.Name.StartsWith("C");
    }
}