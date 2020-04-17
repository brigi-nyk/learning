using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer: EntityBase, ILoggable
    {
        private string _lastName;

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
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

        public static int InstanceCount { get; set; }

        public List<Address> Addresses { get; set; }

        public Customer() : this(0)
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            Addresses = new List<Address>();
        }

        /// <summary>
        /// Validate the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString() => FullName;

        //public string Log()
        //{
        //    var logString = CustomerId + " " +
        //        FullName + " " +
        //        "Email" + EmailAddress;
        //    return logString;
        //}

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} State: {EntityState}";

        
    }
}
