using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotellRoom_system
{
    /* this table going to connect those two tables Room table and Cost table. 
     * we need this table because we have many to many relationship between those tables    
     */
    public class RoomCost
    {
        public int roomCostId { get; set; } // this is the PK 
        public int CostId { get; set; } // this is  the FK
        public int roomId { get; set; } // this one too FK
        public DateTime StartDateCost { get; set; }  // start date for this cost 
        public DateTime EndDateCost { get; set;} // the end date 


    }
}
