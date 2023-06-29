namespace DevTrackR.ShippingOrders.Core.Entities;

public class ShippingService : EntityBase
{
    public ShippingService(string title, decimal pricePerKg, decimal fixedPrice) : base()
    {
        Title = title;
        PricePerKg = pricePerKg;
        FixedPrice = fixedPrice;
    }

    public string  Title { get; set; }
    public decimal PricePerKg { get; set; }
    public decimal FixedPrice { get; set; }
}
