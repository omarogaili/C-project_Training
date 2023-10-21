using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHotelRoomBooking
{
    /*********************************************        klass Rum         *********************************************
     *   i den klassen så tänker jag spara alla tre attribut som vi har om varje rum. 
     *   där vi har room number obvious rum number. 
     *   than we have the room size (is the room singel or double)
     *   and the view ( normal view or ocean view). 
     * 
     */
    internal class Room
    {
        int roomnumber;// key 
        string sizeOfTheRoom;
        string view;
        bool upptagen;

        // Konstraktur 
        public Room(int roomnumber, string sizeOfTheRoom, string view, bool upptagen)
        {
            this.roomnumber = roomnumber;
            this.sizeOfTheRoom = sizeOfTheRoom;
            this.view = view;
            this.upptagen = upptagen;
        }
        public int Roomnumber
        {
            get { return roomnumber; }
            set { roomnumber = value; }
        }
        public string SizeOfTheRoom
        {
            get { return sizeOfTheRoom; }
            set { sizeOfTheRoom = value; }
        }
        public string View
        {
            get { return view; }
            set { view = value; }
        }
        public bool Upptagen
        {
            get { return upptagen;}
            set { upptagen = value; }
        }
    }
}
