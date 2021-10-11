using System;
using CardAbstractFactory.Mastercard;
using CardAbstractFactory.Revolut;

namespace CardAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IProviderFactory providerFactory = new MastercardCardFactory();
            Console.WriteLine(providerFactory.MakeStandardCard().ToString());
            Console.WriteLine(providerFactory.MakePremiumCard().ToString());

            providerFactory = new RevolutCardFactory();
            Console.WriteLine(providerFactory.MakeStandardCard().ToString());
             
            Console.ReadLine();
        }
    }
}
