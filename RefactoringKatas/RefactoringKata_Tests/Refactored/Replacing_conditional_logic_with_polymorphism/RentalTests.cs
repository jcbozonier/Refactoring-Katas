using NUnit.Framework;
using RefactoringKata_Tests.Refactored.Replacing_conditional_logic_with_polymorphism.ObjectsCreatedForTesting;
using RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism;

namespace RefactoringKata_Tests.Refactored.Replacing_conditional_logic_with_polymorphism
{
    namespace Given.a_customer.and_a_movie_rented_for_three_days_PLUS_two_days_past_due.with_a_childrens_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForThreeDays));
            }

            private void Context()
            {
                RentalPeriod = 5;
                var PastDueRentalPeriod = 2;
                var NormalRentalPeriod = RentalPeriod - PastDueRentalPeriod;
                var PerDayRentalFee = 1.5;
                var LateFeePercentageIncrease = 1.5;
                ExpectedMovieRentalCostForThreeDays = NormalRentalPeriod * PerDayRentalFee + PastDueRentalPeriod * PerDayRentalFee * LateFeePercentageIncrease;
                PriceCode = MovieRentalPriceCode.Childrens;
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

                TheRental = new MovieRental(RentalPeriod, new Movie(new Price(PriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private double ExpectedMovieRentalCostForThreeDays;
            private MovieRentalPriceCode PriceCode;
            private int RentalPeriod;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_three_days_PLUS_one_day_past_due.with_a_childrens_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForThreeDays));
            }

            private void Context()
            {
                RentalPeriod = 4;
                var PastDueRentalPeriod = 1;
                var NormalRentalPeriod = RentalPeriod - PastDueRentalPeriod;
                var PerDayRentalFee = 1.5;
                var LateFeePercentageIncrease = 1.5;
                ExpectedMovieRentalCostForThreeDays = NormalRentalPeriod * PerDayRentalFee + PastDueRentalPeriod * PerDayRentalFee * LateFeePercentageIncrease;
                PriceCode = MovieRentalPriceCode.Childrens;
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

                TheRental = new MovieRental(RentalPeriod, new Movie(new Price(PriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private double ExpectedMovieRentalCostForThreeDays;
            private MovieRentalPriceCode PriceCode;
            private int RentalPeriod;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_three_days.with_a_childrens_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForThreeDays));
            }

            private void Context()
            {
                MovieRentalPeriod = 3;
                ExpectedMovieRentalCostForThreeDays = MovieRentalPeriod * 1.5;
                PriceCode = MovieRentalPriceCode.Childrens;
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

                TheRental = new MovieRental(MovieRentalPeriod, new Movie(new Price(PriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForThreeDays;
            private MovieRentalPriceCode PriceCode;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_one_day.with_a_childrens_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForOneDay));
            }

            private void Context()
            {
                MovieRentalPeriod = 1;
                ExpectedMovieRentalCostForOneDay = 1.5;
                PriceCode = MovieRentalPriceCode.Childrens;
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

                TheRental = new MovieRental(MovieRentalPeriod, new Movie(new Price(PriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForOneDay;
            private MovieRentalPriceCode PriceCode;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_two_days.with_a_new_release_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForOneDay));
            }

            private void Context()
            {
                MovieRentalPeriod = 2;
                ExpectedMovieRentalCostForOneDay = MovieRentalPeriod * 3;
                PriceCode = MovieRentalPriceCode.NewRelease;
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

                TheRental = new MovieRental(MovieRentalPeriod, new Movie(new Price(PriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForOneDay;
            private MovieRentalPriceCode PriceCode;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_one_day.with_a_new_release_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForOneDay));
            }

            private void Context()
            {
                MovieRentalPeriod = 1;
                ExpectedMovieRentalCostForOneDay = 3;
                PriceCode = MovieRentalPriceCode.NewRelease;
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

                TheRental = new MovieRental(MovieRentalPeriod, new Movie(new Price(PriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForOneDay;
            private MovieRentalPriceCode PriceCode;
        }
    }

    namespace Given.a_customer.and_a_movie_rented_for_one_day.with_a_regular_price_code
    {
        [TestFixture]
        public class When_charging_a_customer_for_a_rental
        {
            [Test]
            public void It_should_charge_the_customer_the_appropriate_amount()
            {
                Assert.That(OurCustomer.AmountCharged, Is.EqualTo(ExpectedMovieRentalCostForOneDay));
            }

            private void Context()
            {
                MovieRentalPeriod = 1;
                ExpectedMovieRentalCostForOneDay = 2;
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

                MovieRentalPriceCode movieRentalPriceCode = MovieRentalPriceCode.Regular;
                TheRental = new MovieRental(MovieRentalPeriod, new Movie(new Price(movieRentalPriceCode)));

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private int MovieRentalPeriod;
            private double ExpectedMovieRentalCostForOneDay;
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

                TheRental = MovieRental.CreateMovieRentalWithRegularPriceCode(MovieRentalPeriod);

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

                TheRental = MovieRental.CreateMovieRentalWithRegularPriceCode(MovieRentalPeriod);

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

                TheRental = MovieRental.CreateMovieRentalWithRegularPriceCode(MovieRentalPeriod);

                Because();
            }

            private MovieRental TheRental;
            private SecretShopperCustomer OurCustomer;
            private double RentalFeeIncludingLateFee;
            private int MovieRentalPeriod;
        }
    }
}
