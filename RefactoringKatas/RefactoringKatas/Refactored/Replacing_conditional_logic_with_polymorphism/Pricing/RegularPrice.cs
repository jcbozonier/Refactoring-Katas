namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing
{
    public class RegularPrice : IPrice
    {
        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.Regular;
        }
    }
}