using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.DAL.Interfaces;
using Imeshma.Entity;

namespace Imeshma.DAL.Repositroy
{
    public class UserRepo :IUser
    {
        public void AddUser(UserModel model)
        {
            try
            {
                ImeshmaEntities _db = new ImeshmaEntities();
                _db.Users.Add(
                    new User()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        LoginVia = model.LoginVia



                    }
                    );

                _db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
