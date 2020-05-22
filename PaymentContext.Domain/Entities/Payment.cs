namespace PaymentContext.Domain.Entities
{
    // cannot be directly instantiated
    public abstract class Payment
    {
        public string Number { get; set; } // identify payment
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string Document { get; set; }
        public string Address { get; set; } // billing
        public string Email { get; set; }
    }

    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }

    public class CreditCardPayment : Payment // needs gateways of payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; } // last 4 numbers
        public string LastTransactionNumber { get; set; }
    }

    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; set; }
    }
}