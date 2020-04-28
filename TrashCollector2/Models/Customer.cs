using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string PickupDay { get; set; }
        public DateTime OneTimePickup { get; set; }
        public DateTime TempSuspendStart { get; set; }
        public DateTime TempSuspendEnd { get; set; }
        

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser identityUser { get; set; }

    }
}
