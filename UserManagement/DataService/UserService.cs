using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataRepository;

namespace DataService
{
    public class UserService
    {
        UserRepository repo = new UserRepository(); 
       public void GetUsers()
       {
          var users =  repo.GetAll("GetUsers");
       }
    }
}
