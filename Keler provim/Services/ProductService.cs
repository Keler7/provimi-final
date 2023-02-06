using System.Collections.Generic;
using AspNetCoreWebAPI.Models;

namespace AspNetCoreWebAPI.Services
{
    public class ProductService
    {
        List<Product> _productList = null;
        public ProductService()
        {
            _productList = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return _productList;
        }

        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }
    }
}