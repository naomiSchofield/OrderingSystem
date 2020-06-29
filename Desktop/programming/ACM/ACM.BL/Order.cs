using System;
namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        //DateTimeOffSet is good to use when the time can be set in different timezones. 
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;


            return isValid;

        }
        //public Order Retrieve(in orderId)
        //{
        //    //retrieves one order

        //    return new Order();
        //}


       
    }
}
