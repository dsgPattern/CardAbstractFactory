using System;

namespace CardAbstractFactory.Mastercard
{
    public class MastercardCardFactory: IProviderFactory
    {
        public Card MakeStandardCard()
        {
            return new McStandardCard();
        }

        public Card MakePremiumCard()
        {
            return new McPremiumCard();
        }

        public Card MakeGoldCard()
        {
            throw new NotImplementedException();
        }

        public Card MakeUltimateCard()
        {
            throw new NotImplementedException();
        }
    }
}
