using System;

namespace Opgave5_4
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public decimal CreditLimit { get; set; }
        public string CardHolderName { get; set; }

        // Niveau 1: Kun kortnummer og korttype
        public CreditCard(string cardNumber, string cardType)
            : this(cardNumber, cardType, 10000m) // Standard kreditgrænse: 10.000 kr.
        {
        }

        // Niveau 2: Kortnummer, korttype og kreditgrænse
        public CreditCard(string cardNumber, string cardType, decimal creditLimit)
            : this(cardNumber, cardType, creditLimit, "Ukendt Kortholder") // Standard kortholdernavn
        {
        }

        // Niveau 3: Den fulde konstruktør med alle 4 værdier
        public CreditCard(string cardNumber, string cardType, decimal creditLimit, string cardHolderName)
        {
            CardNumber = cardNumber;
            CardType = cardType;
            CreditLimit = creditLimit;
            CardHolderName = cardHolderName;
        }

        public override string ToString()
        {
            return $"Kort: {CardType} ({CardNumber}) | Grænse: {CreditLimit:C} | Kortholder: {CardHolderName}";
        }
    }
}