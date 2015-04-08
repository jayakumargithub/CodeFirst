using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DataModel
{
    public class User
    {
        
        public int Id { get; set; }

        
        public string FirstName { get; set; }

         
        public string LastName { get; set; }

        public int? Age { get; set; }
    }
}
