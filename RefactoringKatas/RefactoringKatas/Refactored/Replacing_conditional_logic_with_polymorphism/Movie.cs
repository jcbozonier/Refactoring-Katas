using RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public class Movie : IMovie
    {
        private readonly IPrice PriceCode;

        public Movie(IPrice price)
        {
            PriceCode = price;
        }

        public MovieRentalPriceCode GetPriceCode()
        {
            return PriceCode.GetPriceCode();
        }
    }
}