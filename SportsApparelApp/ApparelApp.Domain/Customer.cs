using System;
using System.Dynamic;

namespace ApparelApp.Domain
{
    /// <summary>
    /// This class holds names for customers
    /// </summary>
    public class Customer
    {
        public string FirstName { get; }

        public string LastName { get; }

        public Customer(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;

        }
    }
}
