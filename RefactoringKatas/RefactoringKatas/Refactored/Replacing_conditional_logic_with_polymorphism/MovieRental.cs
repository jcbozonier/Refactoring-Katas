using RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism.Pricing;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public class MovieRental
    {
        private readonly int DaysRented;
        private readonly IMovie TheMovie;

        public static MovieRental CreateMovieRentalWithRegularPriceCode(int daysRented)
        {
            return new MovieRental(daysRented, new Movie(new RegularPrice()));
        }

        public MovieRental(int daysRented, IMovie movie)
        {
            DaysRented = daysRented;
            TheMovie = movie;
        }

        public void Charge(IPayingCustomer customer)
        {
            TheMovie.Charge(customer, DaysRented);
        }
    }
}