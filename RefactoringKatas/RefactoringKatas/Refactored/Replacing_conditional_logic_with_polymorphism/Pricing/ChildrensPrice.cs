using System;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing
{
    public class ChildrensPrice : IPrice
    {
        #region Implementation of IPrice

        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.Childrens;
        }

        public void Charge(IPayingCustomer customer, int daysRented)
        {
            var rentalCostPerDay = 1.5;
            var allowedRentalPeriod = 3;
            if (daysRented > allowedRentalPeriod)
            {
                var daysLate = daysRented - allowedRentalPeriod;
                customer.Charge(rentalCostPerDay * allowedRentalPeriod + daysLate * rentalCostPerDay * 1.5);
            }
            else
            {
                var totalRentalFee = rentalCostPerDay * daysRented;
                customer.Charge(totalRentalFee);
            }
        }

        #endregion
    }
}