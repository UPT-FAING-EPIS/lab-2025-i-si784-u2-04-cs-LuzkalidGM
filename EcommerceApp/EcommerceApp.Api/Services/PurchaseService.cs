namespace EcommerceApp.Api.Services
{
    public class PurchaseService
    {
        private readonly IDiscountService _discountService;

        public PurchaseService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public decimal CalculateTotalWithDiscount(decimal unitPrice, int quantity)
        {
            var total = unitPrice * quantity;
            return _discountService.ApplyDiscount(total);
        }

        public decimal CalculateTotalWithTaxAndDiscount(decimal unitPrice, int quantity, decimal taxRate)
        {
            var subtotal = unitPrice * quantity;
            var discounted = _discountService.ApplyDiscount(subtotal);
            return discounted + (discounted * taxRate);
        }
    }
}
