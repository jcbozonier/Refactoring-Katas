namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public class Price : IPrice
    {
        private readonly MovieRentalPriceCode PriceCode;

        public Price(MovieRentalPriceCode priceCode)
        {
            PriceCode = priceCode;
        }

        public MovieRentalPriceCode GetPriceCode()
        {
            return PriceCode;
        }
    }
}