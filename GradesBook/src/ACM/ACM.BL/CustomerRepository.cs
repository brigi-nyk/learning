using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //code that retrieves the defined customer
            Customer customer = new Customer(customerId);

            //temporarly hard coded values to have a customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.Addresses = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            //code that retrieves the defined customer

            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves teh defined customer

            return true;
        }
    }
}
