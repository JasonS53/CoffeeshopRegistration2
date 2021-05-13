using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeshopRegistration2.Models
{
    public class Customers
    {
        [Key]       
        public int CustomerId { get; set; }
        [StringLength (25)]
        public string FirstName { get; set; }
        [StringLength (40)]
        public string LastName { get; set; }
        [StringLength (50)]
        public string Email { get; set; }
        [StringLength (25)]
        public string Password { get; set; }
        [StringLength (15)]
        public string Birthday { get; set; }
        [StringLength (10)]
        public string CoffeeTemp { get; set; }
        [StringLength (10)]
        public string CoffeeType { get; set; }
        [StringLength (10)]
        public string TeaTemp { get; set; }
        [StringLength (10)]
        public string TeaType { get; set; }

    }
}
