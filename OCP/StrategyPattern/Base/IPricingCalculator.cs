namespace OCP.StrategyPattern.Base;

public interface IPricingCalculator
{
    decimal CalculatePrice(OrderItem item);
}