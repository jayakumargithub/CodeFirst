using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
 using System.Data.SqlClient;
using DataAccess;


namespace DataRepository
{

    public interface IUserRepository : IRepository<User>
    {

    }
    public class UserRepository : Repository<User>, IUserRepository
    {
        public void GetAllUsers()
        {
          var userList =  GetAll();
            var user = new User();
            Create(user);
        }

        public void GetUserByName()
        {
            UserManagementContextInstance.Database.SqlQuery<User>("","");
        }

        public void CreateUser()
        {
            object[] obj = new object[3];
            obj[0] =new SqlParameter("firstName", "Johny" );
            obj[1]= new SqlParameter("lastName", "Leaver" );
            obj[2] = new SqlParameter("age", 30);
            ExecuteStoredProcedure("InsertUser @firstName, @lastName, @age", obj);

        }

        public UserAddress GetUserAddress()
        {
            UserAddress userAddress = new UserAddress();
           
            using (var db = new UserManagementContext() )
            {
                var cmd = db.Database.Connection.CreateCommand(); 

                try
                {
                    cmd.CommandText = "GetUsersAddress @userId";
                    db.Database.Connection.Open();
                    var p = new SqlParameter("@userId", SqlDbType.Int);
                    p.Value = 1;
                    cmd.Parameters.Add(p); 

                    var reader = cmd.ExecuteReader();

                    var user = ((IObjectContextAdapter)db)
                        .ObjectContext.Translate<DataModel.User>(reader, "Users", MergeOption.AppendOnly).First();
                    userAddress.User = new User
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Age = user.Age,
                        Id = user.Id
                    };

                    reader.NextResult();
                    var address = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<Address>(reader, "Addresses", MergeOption.AppendOnly).ToList();

                    foreach (var a in address)
                    {
                         userAddress.UserAddresses.Add(new Address{Id = a.Id,DoorNo = a.DoorNo,StreetName = a.StreetName, Country = a.Country, City = a.City});
                    }
                   

                } 
                finally
                {
                    db.Database.Connection.Close();
                }
                return userAddress;
            }
        }
    }
}
