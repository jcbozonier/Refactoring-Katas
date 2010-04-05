using System;
using RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public class Movie : IMovie
    {
        private readonly IPrice PriceCode;

        public Movie(IPrice price)
        {
            PriceCode = price;
        }

        public MovieRentalPriceCode GetPriceCode()
        {
            return PriceCode.GetPriceCode();
        }

        public void Charge(IPayingCustomer customer, int DaysRented)
        {
            switch (GetPriceCode())
            {
                case MovieRentalPriceCode.Regular:
                    {
                        var rentalCostPerDay = 2;
                        var allowedRentalPeriod = 2;

                        if (DaysRented > allowedRentalPeriod)
                        {
                            var lateRentalDays = DaysRented - allowedRentalPeriod;
                            var lateRentalPercentageIncrease = 1.5;
                            var totalRentalFeeIncludingLateFee = allowedRentalPeriod * rentalCostPerDay +
                                                                 lateRentalDays * rentalCostPerDay *
                                                                 lateRentalPercentageIncrease;

                            customer.Charge(totalRentalFeeIncludingLateFee);
                        }
                        else
                        {
                            var totalRentalFee = DaysRented * rentalCostPerDay;
                            customer.Charge(totalRentalFee);
                        }
                        break;
                    }
                case MovieRentalPriceCode.NewRelease:
                    {
                        var rentalCostPerDay = 3;
                        var totalRentalFee = rentalCostPerDay * DaysRented;
                        customer.Charge(totalRentalFee);
                        break;
                    }
                case MovieRentalPriceCode.Childrens:
                    {
                        var rentalCostPerDay = 1.5;
                        var allowedRentalPeriod = 3;
                        if (DaysRented > allowedRentalPeriod)
                        {
                            var daysLate = DaysRented - allowedRentalPeriod;
                            customer.Charge(rentalCostPerDay * allowedRentalPeriod + daysLate * rentalCostPerDay * 1.5);
                        }
                        else
                        {
                            var totalRentalFee = rentalCostPerDay * DaysRented;
                            customer.Charge(totalRentalFee);
                        }

                        break;
                    }
            }
        }
    }
}