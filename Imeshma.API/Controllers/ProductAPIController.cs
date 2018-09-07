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
                //var data = request.data.OrderBy(x => x.UserId).Skip(request.start).Take(request.length);
                //return Json(new
                //{
                //    // this is what datatables wants sending back
                //    //draw = request.draw,
                //    //recordsTotal = request.data.Count,
                //    //recordsFiltered = request.data.Count,
                //    data =data,
                //    //length = request.length,
                //    //message = "success"

                //});
            }
            catch (Exception e)
            {
                //return Json(new
                //{
                //    // this is what datatables wants sending back
                //    draw = request.draw,
                //    recordsTotal = request.data.Count,
                //    recordsFiltered = request.data.Count,
                //    data = request.data,
                //    length = request.length,
                //    message = "error",
                //    exception = e.Message.ToString()
                //});
            }
            return null;
        }

    }
}
