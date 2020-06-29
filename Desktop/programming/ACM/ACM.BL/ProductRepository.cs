using System;
namespace ACM.BL
{
    public class ProductRepository
    {
        
        public Product Retrieve(int productId)
        {

            Product product = new Product(productId);

            if (productId ==2)
            {
                product.CurrentPrice = 1.99m;
                product.ProductDescription = "Classic Mother's day card including personal message";
                product.ProductName = "Classic Mother's day card.";
            }


            return product;
        }


        public bool Save(Product product)
        {


            return true;
        }
    }
}
