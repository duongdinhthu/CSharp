using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcExample.service;
using mvcExample.model;

namespace mvcExample.controller
{
    public class ProductController
    {
        //Instance of model 
        private IProductService productService;
        public ProductController(IProductService proService){
            productService = proService;
        }
        public void AddProduct(Product product){
            productService.AddProduct(product);;
        }
    }
}