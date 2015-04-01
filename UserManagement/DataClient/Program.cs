using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var uService = new DataService.UserService();
            uService.GetUsers();
        }
    }
}
