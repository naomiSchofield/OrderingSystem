using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ACM.BL
{
    public class Customer
    {
        // This is the Default Constructor typing firstCustomer =  new Customer() will create a new object based on the default constructor.     
        public Customer()
        {

        }

        public Customer(int customerId)
        {
           CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        //this is a shorthand way to write the code below. Here the backing field is auto generated. Use this if there is no need for logic within the object getter or setter. 
        public string FirstName { get; set; }

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

        private string _lastName; //this is a backing field, required when holding additional data
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

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }
       
    }

}
