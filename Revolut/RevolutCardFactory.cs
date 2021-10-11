using System;

namespace CardAbstractFactory.Revolut
{
    public class RevolutCardFactory: IProviderFactory
    {
        public Card MakeStandardCard()
        {
            return new RevolutStandardCard();
        }

        public Card MakePremiumCard()
        {
            return new RevolutPremiumCard();
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
