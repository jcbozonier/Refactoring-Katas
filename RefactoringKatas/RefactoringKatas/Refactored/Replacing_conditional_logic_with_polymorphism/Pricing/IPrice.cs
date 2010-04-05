namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing
{
    public interface IPrice
    {
        void Charge(IPayingCustomer customer, int daysRented);
    }
}