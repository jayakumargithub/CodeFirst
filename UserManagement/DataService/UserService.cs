using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataRepository;
using DataModel;

namespace DataService
{

    public interface IUserService
    {
        void GetUsers();
        void CreateUser();
    }
    public class UserService : IUserService
    {
        UserRepository repo = new UserRepository(); 
       public void GetUsers()
       {
          var users =  repo.GetAll("GetUsers");
       }


       public void CreateUser()
       {
           repo.CreateUser();
       }

        public void GetUserAddress()
        {
            repo.GetUserAddress();
        }
    }
}
