using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models.GarbageCollection
{
    namespace GarbageCollector.Models.Garbage
    {
        public class Customer
        {
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Street { get; set; }
            public string Street2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }
            public int PhoneNumber { get; set; }
            public string PickupDay { get; set; }
            public string AmountOwed { get; set; }

            public Customer()
            {

            }


        }
    }
}