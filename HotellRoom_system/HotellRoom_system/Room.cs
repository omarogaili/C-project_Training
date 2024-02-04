using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotellRoom_system
{
    public class Room
    {
         public int roomId {  get; set; }
        public string roomName { get; set; } // the number of the room 
        public int roomFloor { get; set; }   // the floor 
        public int ViewId { get; set; }

    }
}
