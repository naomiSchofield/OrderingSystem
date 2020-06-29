using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductID = productId;
        }

        // ? = the question mark denotes a nullable type -> so the decimal? could be any decimal within the type range and null. This is helpful because the code can distingush between not set and 0. A Price of 0 is a valid price, if there is no price, the value will be NULL. 
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }
        public string ProductName { get; set; }


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) { isValid = false; }
            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
