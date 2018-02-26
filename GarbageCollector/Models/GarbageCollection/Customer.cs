using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace GarbageCollector.Models.GarbageCollection
{
        public class Customer
        {
            public int Id { get; set; }
            
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            public string Street { get; set; }

            [Required]
            [Display(Name = "Street")]
            public string Street2 { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            public string State { get; set; }

            [Required]
            public int Zip { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public int PhoneNumber { get; set; }

            [Required]
            [Display(Name = "Pickup Day")]
            public string PickupDay { get; set; }

            [Required]
            public double AmountPerPickup { get; set; }

        public ICollection<VacationDay> VacationDates { get; set; } = new List<VacationDay>();

        public ICollection<Pickup> PickupDates { get; set; } = new List<Pickup>();

        public Customer()
            {

            }

        public double GetTotalCostForPickupDuringTimePeriod(DateTime d1, DateTime d2)
        {
            DateTime startDate = d1;
            DateTime endDate = d2;
            if ( d2 < d1)
            {
                startDate = d2;
                endDate = d1;
            }
            else
            {
                // won't happen
            }
            double totalCost = PickupDates.Where(w => w.PickupDate <= endDate && w.PickupDate >= startDate).Select(s => s.Charge).Sum();
            return totalCost;
        }


        }
    }