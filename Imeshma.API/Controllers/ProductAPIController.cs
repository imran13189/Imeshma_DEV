using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Imeshma.BAL.Services;
using Imeshma.BAL.Interfaces;
using Imeshma.Entity;


namespace Imeshma.API.Controllers
{
    public class ProductAPIController : ApiController
    {
        public List<Products> GetProductDetails(string search)
        {
            try
            {
                ProductService _rep = new ProductService();
                return _rep.GetProductDetails(search);
               
            }
            catch (Exception e)
            {
                
            }
            return null;
        }

    }
}
