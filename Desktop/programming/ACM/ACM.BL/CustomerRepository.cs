using System;
namespace ACM.BL
{
    public class CustomerRepository
    {
        
        public Customer Retrieve(int customerId)
        {

            Customer customer = new Customer(customerId);

            if (customerId ==1)
            {
                customer.EmailAddress = "fbagging@hobbinton.me";
                customer.FirstName = "frodo";
                customer.LastName = "baggins";

            }


            return customer;
        }



        //public List<Customer> Retrieve()
        //{
        //    //retrieves list of customers


        //    return new List<Customer>();
        //}


        public bool Save(Customer customer)
        {


            return true;
        }
    }
}
