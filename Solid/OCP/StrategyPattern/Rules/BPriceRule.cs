using OCP.StrategyPattern.Base;

namespace OCP.StrategyPattern.Rules;

public class BPriceRule : IPriceRule
{
    public decimal CalculatePrice(OrderItem item)
    {
        return item.Quantity * 4;
    }

    public bool IsMatch(OrderItem item)
    {
        return item.Name.StartsWith("B");
    }
}