namespace Delegates;

public class EventHelper
{
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs (decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice; NewPrice = newPrice;
        }
    }
    public class Stock
    {
        string _symbol;
        decimal _price;
        public Stock (string symbol) => this._symbol = symbol;
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        protected virtual void OnPriceChanged (PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke (this, e);
        }
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price == value) return;
                decimal oldPrice = _price;
                _price = value;
                OnPriceChanged (new PriceChangedEventArgs (oldPrice, _price));
            }
        }
    }
}