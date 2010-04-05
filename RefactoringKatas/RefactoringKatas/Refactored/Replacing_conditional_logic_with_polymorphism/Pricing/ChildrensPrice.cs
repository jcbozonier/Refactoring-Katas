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

        #endregion
    }
}