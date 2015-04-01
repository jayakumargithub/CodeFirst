using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataRepository
{
    public class UserRepository : Repository<User>
    {
        public void GetAllUsers()
        {
          var userList =  GetAll();
        }

    }
}
