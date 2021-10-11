using System;

namespace CardAbstractFactory.Revolut
{
    public class RevolutPremiumCard : Card
    {
        public RevolutPremiumCard()
            : base(CardType.Premium)
        {
            SetupCardShipping();
        }

        protected override void AddBenefits()
        {
            Benefits = "100.000 limit and travel insurance";
        }

        private void SetupCardShipping()
        {
            Console.WriteLine("You are entitled to free shipping");
        }
    }
}
