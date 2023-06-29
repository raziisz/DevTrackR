namespace DevTrackR.ShippingOrders.Core.Entities;

public class ShippingOrderService : EntityBase
{
    public ShippingOrderService(string title, decimal price): base()
    {
        Title = title;
        Price = price;
    }

    public string Title { get; set; }
    public decimal Price { get; set; }
}
