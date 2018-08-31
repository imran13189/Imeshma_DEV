using Imeshma.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.DAL.Interfaces;
using Imeshma.DAL.Repositroy;
using Imeshma.Entity;

namespace Imeshma.BAL.Services
{
    public class ProductService :IProductService
    {
        IProductRepo _productRepo;
        public ProductService()
        {
            _productRepo = new ProductRepo();
        }
        public List<Product> GetProductDetails()
        {
            return _productRepo.GetProductDetails();
        }

    }
}
