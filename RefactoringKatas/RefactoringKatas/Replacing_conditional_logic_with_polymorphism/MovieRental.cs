using System;

namespace RefactoringKatas.Replacing_conditional_logic_with_polymorphism
{
    public class MovieRental
    {
        private readonly int DaysRented;

        public MovieRental(int daysRented)
        {
            DaysRented = daysRented;
        }

        public void Charge(IPayingCustomer customer)
        {
            var rentalCostPerDay = 2;
            var allowedRentalPeriod = 2;

            if (DaysRented > allowedRentalPeriod)
            {
                var lateRentalDays = DaysRented - allowedRentalPeriod;
                var lateRentalPercentageIncrease = 1.5;
                var totalRentalFeeIncludingLateFee = allowedRentalPeriod * rentalCostPerDay + lateRentalDays * rentalCostPerDay * lateRentalPercentageIncrease;
                
                customer.Charge(totalRentalFeeIncludingLateFee);
            }
            else
                customer.Charge(DaysRented * rentalCostPerDay);
        }
    }
}