using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcExample.model;

namespace mvcExample.service
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

    }
}