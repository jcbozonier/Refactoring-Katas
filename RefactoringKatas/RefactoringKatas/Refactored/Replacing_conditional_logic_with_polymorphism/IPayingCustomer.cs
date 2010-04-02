namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public interface IPayingCustomer
    {
        void Charge(double amountCharged);
    }
}