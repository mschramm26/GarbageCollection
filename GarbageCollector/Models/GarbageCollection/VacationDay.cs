using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models.GarbageCollection
{
    public class VacationDay
    { 
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime VacationDate { get; set; }
    }
}