using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBook.Models
{
    class Address
    {
        public string Country { get; set; }

        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        public Address(string street, string houseNumber)
        {
            Country = "Uzbekistan";
            Region = "Tashkent";
            City = "Tashkent";
            Street = street;
            HouseNumber = houseNumber;
        }
    }
}
