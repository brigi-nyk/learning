using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        private string _lastName;

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string EmailAddress { get; set; }

        public static int InstanceCount{ get; set; }

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }


        

        

        /// <summary>
        /// Validate the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
