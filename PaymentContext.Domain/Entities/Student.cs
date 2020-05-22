using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; } // delivery

        // "add" isn't accessible directly
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        private IList<Subscription> _subscriptions;

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            // if active = true, cancel

            // cancel all the subsc. and set this as principal
            foreach (Subscription subscriptionItem in Subscriptions)
                subscriptionItem.Inactivate();
            
            _subscriptions.Add(subscription);
        }

    }
}