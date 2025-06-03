namespace EcommerceApp.Api.Services
{
    public interface IDiscountService
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
}
