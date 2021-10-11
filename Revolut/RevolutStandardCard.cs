namespace CardAbstractFactory.Revolut
{
    public class RevolutStandardCard : Card
    {
        public RevolutStandardCard()
            : base(CardType.Standard)
        {

        }


        protected override void AddBenefits()
        {
            Benefits = "10.000 limit";
        }
    }
}
