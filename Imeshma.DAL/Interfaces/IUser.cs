using Imeshma.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imeshma.DAL.Interfaces
{
    public interface IUser
    {
        void AddUser(UserModel model);
    }
}
