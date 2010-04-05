using System;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing
{
    public class NewReleasePrice : IPrice
    {
        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.NewRelease;
        }

        public void Charge(IPayingCustomer customer, int daysRented)
        {
            var rentalCostPerDay = 3;
            var totalRentalFee = rentalCostPerDay * daysRented;
            customer.Charge(totalRentalFee);
        }
    }
}