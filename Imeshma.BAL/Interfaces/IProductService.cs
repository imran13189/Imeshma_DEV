using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.Entity;
namespace Imeshma.BAL.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProductDetails();
       
    }
}
