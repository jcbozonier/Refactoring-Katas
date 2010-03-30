using NUnit.Framework;
using RefactoringKata_Tests.Replacing_conditional_logic_with_polymorphism.ObjectsCreatedForTesting;
using RefactoringKatas.Replacing_conditional_logic_with_polymorphism;

namespace RefactoringKata_Tests.Replacing_conditional_logic_with_polymorphism
{
    namespace Given.a_customer.and_a_movie_rented_for_one_day.with_a_regular_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForTwoDays));
            }

            private void Context()
            {
                MovieRentalPeriod = 1;
                ExpectedMovieRentalCostForTwoDays = 2;
            }

            private void Because()
            {
                TheRental.Charge(OurCustomer);
            }

            [TestFixtureSetUp]
            public void Setup()
            {
                OurCustomer = new SecretShopperCustomer();
                Context();

                TheRental = new MovieRental(MovieRentalPeriod);

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForTwoDays;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_two_days.with_a_regular_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForTwoDays));
            }

            private void Context()
            {
                MovieRentalPeriod = 2;
                ExpectedMovieRentalCostForTwoDays = 2 * 2;
            }

            private void Because()
            {
                TheRental.Charge(OurCustomer);
            }
            
            [TestFixtureSetUp]
            public void Setup()
            {
                OurCustomer = new SecretShopperCustomer();
                Context();

                TheRental = new MovieRental(MovieRentalPeriod);

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForTwoDays;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_two_days_PLUS_one_day_past_due_date.with_a_regular_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount_plus_late_fee()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(RentalFeeIncludingLateFee));
            }

            public void Context()
            {
                var DaysRentedAtRegularPrice = 2;
                var DaysRentedBeyondDueDate = 1;
                MovieRentalPeriod = DaysRentedAtRegularPrice + DaysRentedBeyondDueDate;
                var MovieCost = 2;
                var LateFeePercentage = 1.5;

                RentalFeeIncludingLateFee = DaysRentedAtRegularPrice * MovieCost + DaysRentedBeyondDueDate * MovieCost * LateFeePercentage;
            }

            private void Because()
            {
                TheRental.Charge(OurCustomer);
            }

            [TestFixtureSetUp]
            public void Setup()
            {
                OurCustomer = new SecretShopperCustomer();

                Context();

                TheRental = new MovieRental(MovieRentalPeriod);

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private double RentalFeeIncludingLateFee;
            private int MovieRentalPeriod;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_two_days_PLUS_two_days_past_due_date.with_a_regular_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount_plus_late_fee()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(RentalFeeIncludingLateFee));
            }

            public void Context()
            {
                var DaysRentedAtRegularPrice = 2;
                var DaysRentedBeyondDueDate = 2;
                MovieRentalPeriod = DaysRentedAtRegularPrice + DaysRentedBeyondDueDate;
                var MovieCost = 2;
                var LateFeePercentage = 1.5;

                RentalFeeIncludingLateFee = DaysRentedAtRegularPrice * MovieCost + DaysRentedBeyondDueDate * MovieCost * LateFeePercentage;
            }

            private void Because()
            {
                TheRental.Charge(OurCustomer);
            }

            [TestFixtureSetUp]
            public void Setup()
            {
                OurCustomer = new SecretShopperCustomer();

                Context();

                TheRental = new MovieRental(MovieRentalPeriod);

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private double RentalFeeIncludingLateFee;
            private int MovieRentalPeriod;
        }
    }
}
