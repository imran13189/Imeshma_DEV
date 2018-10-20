using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Imeshma.DAL.Interfaces;
using Imeshma.DAL.Repositroy;
using Imeshma.Entity;
namespace Imeshma.API.Controllers
{
    public class UserAPIController : ApiController
    {
        [HttpPost]
        public dynamic AddUer(UserModel model)
        {
            try
            {
                IUser _user = new UserRepo();

             _user.AddUser(model);
                return null;

            }
            catch (Exception e)
            {

            }
            return null;
        }
    }
}
