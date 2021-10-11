using System;
using System.Collections.Generic;
using System.Text;

namespace CardAbstractFactory
{
    public interface IProviderFactory
    {
        Card MakeStandardCard();
        Card MakePremiumCard();
        Card MakeGoldCard();
        Card MakeUltimateCard();
    }
}
