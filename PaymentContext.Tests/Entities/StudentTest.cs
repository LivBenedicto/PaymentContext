using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void AddSubscription()
        {
            Subscription subscription = new Subscription(null);
            Student student = new Student("André", "Baltieri", "98765432100", "email@email.com");
            student.AddSubscription(subscription);
        }
    }
}
