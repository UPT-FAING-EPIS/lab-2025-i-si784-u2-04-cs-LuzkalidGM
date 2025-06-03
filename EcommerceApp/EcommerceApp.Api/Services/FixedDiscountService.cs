namespace EcommerceApp.Api.Services
{
    public class FixedDiscountService : IDiscountService
    {
        private readonly decimal _discountRate;

        public FixedDiscountService(decimal discountRate)
        {
            _discountRate = discountRate; // Ej. 0.1 para 10%
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * (1 - _discountRate);
        }
    }
}
