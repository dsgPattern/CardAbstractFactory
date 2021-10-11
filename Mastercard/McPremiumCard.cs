using System;

namespace CardAbstractFactory.Mastercard
{
    public class McPremiumCard: Card
    {
        public McPremiumCard() : base(CardType.Premium)
        {
            SetupCardImage();
        }

        protected override void AddBenefits()
        {
            Benefits = "Travel insurance, shopping deals and all kind of airports/trainstations discounts";
        }

        private void SetupCardImage()
        {
            Console.WriteLine("As a premium user your are entitled to a custom engravement");
        }
    }
}
