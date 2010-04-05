using System;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing
{
    public class RegularPrice : IPrice
    {
        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.Regular;
        }

        public void Charge(IPayingCustomer customer, int daysRented)
        {
            var rentalCostPerDay = 2;
            var allowedRentalPeriod = 2;

            if (daysRented > allowedRentalPeriod)
            {
                var lateRentalDays = daysRented - allowedRentalPeriod;
                var lateRentalPercentageIncrease = 1.5;
                var totalRentalFeeIncludingLateFee = allowedRentalPeriod * rentalCostPerDay +
                                                     lateRentalDays * rentalCostPerDay *
                                                     lateRentalPercentageIncrease;

                customer.Charge(totalRentalFeeIncludingLateFee);
            }
            else
            {
                var totalRentalFee = daysRented * rentalCostPerDay;
                customer.Charge(totalRentalFee);
            }
        }
    }
}