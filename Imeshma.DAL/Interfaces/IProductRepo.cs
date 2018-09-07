using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.Entity;
namespace Imeshma.DAL.Interfaces
{
    public  interface IProductRepo
    {
        List<Products> GetProductDetails(string search);

        void SaveProducts(List<Product> products);

      
    }
}
