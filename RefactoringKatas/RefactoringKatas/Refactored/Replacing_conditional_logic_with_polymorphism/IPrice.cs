namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public interface IPrice
    {
        MovieRentalPriceCode GetPriceCode();
    }
}