using OCP.StrategyPattern.Base;

namespace OCP.StrategyPattern;

public class Cart
{
    private readonly List<OrderItem> _items;
    private readonly IPricingCalculator _pricingCalculator;

    public Cart() : this(new PricingCalculator())
    {
    }

    public Cart(IPricingCalculator pricingCalculator)
    {
        _pricingCalculator = pricingCalculator;
        _items = new List<OrderItem>();
    }

    public IEnumerable<OrderItem> Items
    {
        get { return _items; }
    }

    public void Add(OrderItem orderItem)
    {
        _items.Add(orderItem);
    }

    public decimal TotalAmount()
    {
        return Items.Sum(orderItem => _pricingCalculator.CalculatePrice(orderItem));
    }
}