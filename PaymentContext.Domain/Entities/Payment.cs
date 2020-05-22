using System;

namespace PaymentContext.Domain.Entities
{
    // cannot be directly instantiated
    public abstract class Payment
    {
        public string Number { get; private set; } // identify payment
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public string Document { get; private set; }
        public string Address { get; private set; } // billing
        public string Email { get; private set; }

        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
            string payer, string document, string address, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }
    }
}