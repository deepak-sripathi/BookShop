namespace BookShop.BuisnessLayer.Interfaces
{
    public interface ICalculateDiscount
    {
        decimal GetDiscount(decimal subtotal);
    }
}
