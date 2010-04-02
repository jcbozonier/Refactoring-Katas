using System;
using NUnit.Framework;
using RefactoringKatas.Original.Replacing_conditional_logic_with_polymorphism;

namespace RefactoringKata_Tests.Original.Replacing_conditional_logic_with_polymorphism.ObjectsCreatedForTesting
{
    public class SecretShopperCustomer : IPayingCustomer
    {
        public double AmountCharged;

        #region Implementation of IPayingCustomer

        public void Charge(double amountCharged)
        {
            AmountCharged = amountCharged;
        }

        #endregion
    }
}