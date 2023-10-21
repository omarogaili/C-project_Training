using OnlineHotelRoomBooking;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //Dictionary<Room, string> theRooms = new Dictionary<Room, string>();
        List<Room> hotelRooms = new List<Room>();
        int viewudds = 0;
        // 200, för att vi har 200 rum. 
        for (int i = 0; i <= 200; i++)
        { 
            Random rnd = new Random();
            int roomId = i;
            string size = "singel";
            string view = "vanlig utsikt"; 
            bool upptagen= rnd.Next(2)==0;
            hotelRooms.Add(new Room(roomId, size, view, upptagen));  
            if( roomId % 2 !=0 )
            {
                roomId = i;
                size = "singel";
                view = "Ocean view";
            } 
            
            hotelRooms.Add(new Room (roomId,size, view, upptagen));
        }
        foreach (Room room in hotelRooms)
        {
           Console.WriteLine($"{room.Roomnumber} Utsikten: {room.View} Rommet är: {room.Upptagen} ");
        }
        List<Person>person= new List<Person>();
        //Random rnd= new Random();
        //int index= rnd.Next(hotelRooms.Count);
        //int besökande= rnd.Next(person.Count);
        AddPersonToTheList(person, hotelRooms);
    }
    static void AddPersonToTheList(List<Person> mylist, List<Room> hotelRooms)
    {
        //for (int i = 0;i <=hotelRooms.Count;i++)
        //{
            foreach (Room room in hotelRooms)
            {
                Console.WriteLine(room.Roomnumber);
                Console.Write("vad heter du: ");
                string namn = Console.ReadLine();
                Console.Write("när ska du komma:  ");
                DateTime inDate = DateTime.Parse(Console.ReadLine());
                Console.Write("när ska du ut:  ");
                DateTime outDate = DateTime.Parse(Console.ReadLine());
                mylist.Add(new Person(namn, inDate, outDate));
            }
    }

    static DateTime SökningEfterLedigaRum(List<Room> hotelRooms, DateTime sokEfter)
    {

        for (int i = 0; i < hotelRooms.Count; i++)
        {
            
        }
        return sokEfter;
    }
}