using System;
using HotellRoom_system;
using Microsoft.EntityFrameworkCore;


internal class Program
{
    private static void Main(string[] args)
    {
        using (var _context = new ApplicationDbContex())
        {
            _context.Database.EnsureCreated();
            var Customer= new Customer();
            Console.Write("ange ditt förnamn: ");
            string firstName= Console.ReadLine();
            Customer.FirstName = firstName;
            Console.Write("ange ditt efternamn: ");
            string lastName= Console.ReadLine();
            Customer.LastName = lastName;
            Console.Write("ange din telefone: ");
            string phone= Console.ReadLine();
            Customer.Phone = phone;
            Console.Write("ange din Adress: ");
            string adress= Console.ReadLine();
            Customer.Address = adress;
            Console.Write("ange postnummer: ");
            string post= Console.ReadLine();
            Customer.postNumber = post;
            Console.Write("ange ditt stad: ");
            string city= Console.ReadLine();
            Customer.City = city;
            _context.Customers.Add(Customer);
            _context.SaveChanges();
        }

        //var Customer = new Customer();
        //Console.Write("ange ditt namn: ");
        //string name= Console.ReadLine();
        //name = Customer.FirstName;
        //using var _context = new ApplicationDbContex();

    }

}