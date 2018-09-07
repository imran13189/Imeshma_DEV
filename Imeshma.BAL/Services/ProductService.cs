using Imeshma.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.DAL.Interfaces;
using Imeshma.DAL.Repositroy;
using Imeshma.Entity;
using Imeshma.DAL;

namespace Imeshma.BAL.Services
{
    public class ProductService : IProductService
    {
        IProductRepo _productRepo;
        public ProductService()
        {
            _productRepo = new ProductRepo();
        }
        public List<Products> GetProductDetails(string search)
        {
            return _productRepo.GetProductDetails(search);
        }
        public void SaveProducts(List<Product> products)
        {
            _productRepo.SaveProducts(products);
        }
    }
}
