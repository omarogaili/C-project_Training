using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellRoom_system
{
    public class Bill
    {
        public int billId { get; set; }
        public int CostId { get; set; }// FK this how much they should pay. 
    }
}
