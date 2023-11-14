using AddessBook.Models;
using AddessBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Amir Temur","131");
            AddressService addressService = new AddressService();

            Console.WriteLine(addressService.GetFullAddress(address));

            Console.ReadKey();
        }
        
    }
}
