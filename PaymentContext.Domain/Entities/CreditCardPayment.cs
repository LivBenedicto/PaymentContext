using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment // needs gateways of payment
    {
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; } // last 4 numbers
        public string LastTransactionNumber { get; private set; }

        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber,
            DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer,
            string document, string address, string email)
            : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }
    }
}