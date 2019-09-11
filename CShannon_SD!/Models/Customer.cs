using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CShannon_SD_.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}