﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
   public  class Address
    {
        public int Id { get; set; }
        public int DoorNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
