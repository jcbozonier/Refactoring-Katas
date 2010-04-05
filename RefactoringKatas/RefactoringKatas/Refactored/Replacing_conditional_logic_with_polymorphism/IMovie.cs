namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public interface IMovie
    {
        void Charge(IPayingCustomer customer, int daysRented);
    }
}