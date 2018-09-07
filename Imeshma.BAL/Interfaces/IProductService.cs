using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.Entity;
using Imeshma.DAL;
namespace Imeshma.BAL.Interfaces
{
    public interface IProductService
    {
        List<Products> GetProductDetails(string search);

        void SaveProducts(List<Product> products);
    }
}
