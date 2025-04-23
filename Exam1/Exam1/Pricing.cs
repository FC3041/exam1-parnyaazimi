namespace Exam1;


public interface IPrice
{
    public double Price(double _Price);
}

public class NoDiscountStrategy : IPrice
{
    public double Price(double _Price)
    {
        return _Price;
    }
}

public class PercentageDiscountStrategy : IPrice
{
    public double Discount;
    public PercentageDiscountStrategy(double _Discount)
    {
        Discount=_Discount;
    }
    public double Price(double _Price)
    {
        _Price=_Price-(_Price*Discount);
        return _Price;
    }
}
public class PricingEngine
{
    public IPrice PriceStrategy;
    public PricingEngine(IPrice _PriceStrategy)
    {
        PriceStrategy=_PriceStrategy;
    }

    public void SetStrategy(IPrice Strategy)
    {
        PriceStrategy=Strategy;
    }
    public double CalculatePrice(double price)
    {
        return PriceStrategy.Price(price);
    }
}

