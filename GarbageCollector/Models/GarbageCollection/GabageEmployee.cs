using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models.GarbageCollection
{
    namespace GarbageCollector.Models.Garbage
    {
        public class Employee
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ZipCodeAssigned { get; set; }

            public List<Customer> DayRoute { get; set; }

            public Employee()
            {

            }



        }
    }
}