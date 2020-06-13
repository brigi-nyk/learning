using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobiton";
                address.State = "Shire";
                address.Country = "Midle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobiton",
                State = "Shire",
                Country = "Midle Earth",
                PostalCode = "144"

            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Midle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current order 
        /// </summary>
        /// <returns></returns>
        public bool Save(Address adress)
        {
            //code that saves teh defined order 

            return true;
        }
    }
}
