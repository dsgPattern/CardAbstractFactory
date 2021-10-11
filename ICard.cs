using System;

namespace CardAbstractFactory
{
    public interface ICard
    {
        void CreateCard();
        string No { get; }
        int Ccv { get; }
        DateTime ExpirationDate { get; }
    }
}
