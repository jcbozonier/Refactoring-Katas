using RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public interface IMovie
    {
        MovieRentalPriceCode GetPriceCode();
    }
}