using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CShannon_SD_.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
        public DateTime orderDate { get; set; }
    }
}