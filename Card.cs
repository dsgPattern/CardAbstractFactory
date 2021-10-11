using System;

namespace CardAbstractFactory
{
    public abstract class Card
    {
        public string No { get; private set; }
        public CardType Type { get; }
        public DateTime ExpirationDate { get; private set; }
        public int Ccv { get; private set; }
        public string Color { get; protected set; }

        public string Benefits { get; protected set; }

        protected Card(CardType type)
        {
            Type = type;
            CreateCard();
            AddBenefits();
        }

        private void CreateCard()
        {
            No = Guid.NewGuid().ToString();
            Ccv = new Random(1000).Next(100, 999);
            ExpirationDate = DateTime.Now.AddYears(3);
        }

        protected abstract void AddBenefits();

        public override string ToString()
        {
            return $"{GetType()} with No: {No} will expire in {ExpirationDate.ToShortDateString()}. \r Benefits included: {Benefits}.";
        }
    }
}
