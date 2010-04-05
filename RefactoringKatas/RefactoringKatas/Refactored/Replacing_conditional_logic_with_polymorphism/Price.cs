using System;

namespace RefactoringKatas.Refactored.Replacing_conditional_logic_with_polymorphism
{
    public class RegularPrice : IPrice
    {
        #region Implementation of IPrice

        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.Regular;
        }

        #endregion
    }

    public class NewReleasePrice : IPrice
    {
        #region Implementation of IPrice

        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.NewRelease;
        }

        #endregion
    }

    public class ChildrensPrice : IPrice
    {
        #region Implementation of IPrice

        public MovieRentalPriceCode GetPriceCode()
        {
            return MovieRentalPriceCode.Childrens;
        }

        #endregion
    }
}