using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migration_database
{
    public class Topay
    {
        public int Id { get; set; }//PK
        public decimal ToPay { get; set; } // total price to pay
        public decimal Price { get; set; } // the price that the customer buy for
        public int customerId { get; set; }//FK
        public DateOnly BillDate { get; set; }
    }
}
