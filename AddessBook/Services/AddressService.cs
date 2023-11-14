using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddessBook.Models;

namespace AddessBook.Services
{
    class AddressService
    {
        public string GetFullAddress(Address address)
        {
            return $"{address.Country}, {address.Region}, {address.City}, {address.Street}, {address.HouseNumber}";
        }
    }
}
