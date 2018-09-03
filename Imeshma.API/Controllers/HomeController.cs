using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Imeshma.BAL.Services;
using Imeshma.BAL.Interfaces;
using Imeshma.Entity;
using Imeshma.DAL;


namespace Imeshma.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string htmlCode = client.DownloadString(url);
                    ViewBag.HTML = htmlCode;
                }

                return View();
            }
            catch
            {
                return null;
            }
        }

        public ActionResult URLPAGE()
        {
           

                return View();
          
        }

        [HttpPost]
        public ActionResult SaveProducts(List<Product> products)
        {
            try
            {
                IProductService _rep = new ProductService();
                products.ForEach(x => x.CreatedDate = DateTime.UtcNow);
                _rep.SaveProducts(products);
            }
            catch
            {

            }
            return null;
        }
    }
}
