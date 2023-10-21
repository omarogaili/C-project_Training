using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHotelRoomBooking
{
    internal class Person
    {
        string name;
        DateTime dateIn;
        DateTime dateOut;

        public Person (string name, DateTime dateIn, DateTime dateOut)
        {
            this.name = name;
            this.dateIn = dateIn;
            this.dateOut = dateOut;
        }
        public string namne
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DateIn
        {
          get { return dateIn; }
            set { dateIn = value; }
        }
        public DateTime DateOut
        {
            get { return dateOut; }
            set { dateOut = value; }
        }
    }
}
