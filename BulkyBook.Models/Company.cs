using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }

        public int StreetAddress { get; set; }

        public int City { get; set; }

        public int State { get; set; }

        public int PostalCode { get; set; }

        public int PhoneNumber { get; set; }
    }
}

