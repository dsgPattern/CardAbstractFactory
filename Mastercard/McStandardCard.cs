namespace CardAbstractFactory.Mastercard
{
    public class McStandardCard: Card
    {
        public McStandardCard() : base(CardType.Standard)
        {
        }

        protected override void AddBenefits()
        {
            Benefits = "ID Theft protection";
        }
    }
}
