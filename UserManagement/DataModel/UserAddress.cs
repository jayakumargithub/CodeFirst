using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class UserAddress
    {
        public UserAddress()
        {
            User = new User();
            UserAddresses = new List<Address>();
        }
        public User User { get; set; }
        public  List<Address> UserAddresses { get; set; }
    }
}
